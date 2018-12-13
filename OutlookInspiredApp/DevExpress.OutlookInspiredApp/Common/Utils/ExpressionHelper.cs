using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DevExpress.DevAV.Common.Utils {
    /// <summary>
    /// Provides methods to perform operations with lambda expression trees.
    /// </summary>
	public class ExpressionHelper {
        class ValueHolder<T> {
            public readonly T value;
            public ValueHolder(T value) {
                this.value = value;
            }
        }

        static readonly Dictionary<Type, object> TraitsCache = new Dictionary<Type, object>();

        /// <summary>
        /// Builds a lambda expression that compares an entity property value with a given constant value.
        /// </summary>
        /// <typeparam name="TPropertyOwner">An owner type of the property.</typeparam>
        /// <typeparam name="TProperty">A primary key property type.</typeparam>
        /// <param name="getPropertyExpression">A lambda expression that returns the property value for a given entity.</param>
        /// <param name="constant">A constant value to compare with entity property value.</param>
        public static Expression<Func<TPropertyOwner, bool>> GetValueEqualsExpression<TPropertyOwner, TProperty>(Expression<Func<TPropertyOwner, TProperty>> getPropertyExpression, TProperty constant) {
            Expression equalExpression = Expression.Equal(getPropertyExpression.Body, Expression.Convert(Expression.Field(Expression.Constant(new ValueHolder<TProperty>(constant)), "value"), getPropertyExpression.Body.Type));
            return Expression.Lambda<Func<TPropertyOwner, bool>>(equalExpression, getPropertyExpression.Parameters.Single());
        }

        /// <summary>
        /// Returns an instance of the EntityTraits class that encapsulates operations to obtain and set the primary key value of a given entity.
        /// </summary>
        /// <typeparam name="TOwner">A type used as a key to cache compiled lambda expressions.</typeparam>
        /// <typeparam name="TPropertyOwner">An owner type of the primary key property.</typeparam>
        /// <typeparam name="TProperty">A primary key property type.</typeparam>
        /// <param name="owner">An instance of the TOwner type which type is used as a key to cache compiled lambda expressions.</param>
        /// <param name="getPropertyExpression">A lambda expression that returns the primary key value for a given entity.</param>
        public static EntityTraits<TPropertyOwner, TProperty> GetEntityTraits<TOwner, TPropertyOwner, TProperty>(TOwner owner, Expression<Func<TPropertyOwner, TProperty>> getPropertyExpression) {
            object traits = null;
            if(!TraitsCache.TryGetValue(owner.GetType(), out traits)) {
                traits = new EntityTraits<TPropertyOwner, TProperty>(getPropertyExpression.Compile(), GetSetValueActionExpression(getPropertyExpression).Compile(), GetHasValueFunctionExpression(getPropertyExpression).Compile());
                TraitsCache[owner.GetType()] = traits;
            }
            return (EntityTraits<TPropertyOwner, TProperty>)traits;
        }

        /// <summary>
        /// Determines whether the given entity satisfies the condition represented by a lambda expression.
        /// </summary>
        /// <typeparam name="TEntity">A type of the given object.</typeparam>
        /// <param name="entity">An object to test.</param>
        /// <param name="predicate">A function that determines whether the given object satisfies the condition.</param>
        public static bool IsFitEntity<TEntity>(TEntity entity, Expression<Func<TEntity, bool>> predicate) where TEntity : class {
            return predicate == null || (new TEntity[] { entity }.AsQueryable().Any(predicate));
        }

        /// <summary>
        /// Converts a property reference represented as a lambda expression to a property name.
        /// </summary>
        /// <param name="expression">A lambda expression that returns the property value.</param>
        public static string GetPropertyName(LambdaExpression expression) {
            Expression body = expression.Body;
            if(body is UnaryExpression) {
                body = ((UnaryExpression)body).Operand;
            }
            var memberExpression = ValidateMemberExpression((MemberExpression)body);
            return memberExpression.Member.Name;
        }

        static MemberExpression ValidateMemberExpression(MemberExpression memberExpression) {
            if(IsNullableValueExpression(memberExpression))
                memberExpression = (MemberExpression)memberExpression.Expression;
            return memberExpression;
        }

        static bool IsNullableValueExpression(MemberExpression memberExpression) {
            var propertyInfo = (PropertyInfo)memberExpression.Member;
            return propertyInfo.PropertyType.IsValueType && propertyInfo.ReflectedType == typeof(Nullable<>).MakeGenericType(propertyInfo.PropertyType) && propertyInfo.Name == "Value";
        }

        static Expression<Action<TPropertyOwner, TProperty>> GetSetValueActionExpression<TPropertyOwner, TProperty>(Expression<Func<TPropertyOwner, TProperty>> getPropertyExpression) {
            MemberExpression body = ValidateMemberExpression((MemberExpression)getPropertyExpression.Body);
            ParameterExpression thisParameter = getPropertyExpression.Parameters.Single();
            ParameterExpression propertyValueParameter = Expression.Parameter(typeof(TProperty), "propertyValue");

            Expression keyValueExpression = propertyValueParameter;
            if(IsNullableValueExpression((MemberExpression)getPropertyExpression.Body)) {
                var constructor = typeof(Nullable<>).MakeGenericType(typeof(TProperty)).GetConstructor(new Type[] { typeof(TProperty) });
                keyValueExpression = Expression.New(constructor, keyValueExpression);
            }

            BinaryExpression assignPropertyValueExpression = Expression.Assign(body, keyValueExpression);
            return Expression.Lambda<Action<TPropertyOwner, TProperty>>(assignPropertyValueExpression, thisParameter, propertyValueParameter);
        }

        static Expression<Func<TPropertyOwner, bool>> GetHasValueFunctionExpression<TPropertyOwner, TProperty>(Expression<Func<TPropertyOwner, TProperty>> getPropertyExpression) {
            MemberExpression memberExpression = (MemberExpression)getPropertyExpression.Body;
            if(IsNullableValueExpression(memberExpression)) {
                Expression equalExpression = Expression.NotEqual(memberExpression.Expression, Expression.Constant(null));
                return Expression.Lambda<Func<TPropertyOwner, bool>>(equalExpression, getPropertyExpression.Parameters.Single());
            }
            return x => true;
        }

    }

    /// <summary>
    /// Incapsulates operations to obtain and set the primary key value of a given entity.
    /// </summary>
    /// <typeparam name="TEntity">An owner type of the primary key property.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key property type.</typeparam>
    public class EntityTraits<TEntity, TPrimaryKey> {

        /// <summary>
        /// Initializes a new instance of EntityTraits class.
        /// </summary>
        /// <param name="getPrimaryKeyFunction">A function that returns the primary key value of a given entity.</param>
        /// <param name="setPrimaryKeyAction">An action that assigns the primary key value to a given entity.</param>
        /// <param name="hasPrimaryKeyFunction">A function that determines whether given the entity has a primary key assigned.</param>
        public EntityTraits(Func<TEntity, TPrimaryKey> getPrimaryKeyFunction, Action<TEntity, TPrimaryKey> setPrimaryKeyAction, Func<TEntity, bool> hasPrimaryKeyFunction) {
            this.GetPrimaryKey = getPrimaryKeyFunction;
            this.SetPrimaryKey = setPrimaryKeyAction;
            this.HasPrimaryKey = hasPrimaryKeyFunction;
        }

        /// <summary>
        /// The function that returns the primary key value of a given entity.
        /// </summary>
        public Func<TEntity, TPrimaryKey> GetPrimaryKey { get; private set; }

        /// <summary>
        /// The action that assigns the primary key value to a given entity.
        /// </summary>
        public Action<TEntity, TPrimaryKey> SetPrimaryKey { get; private set; }

        /// <summary>
        /// A function that determines whether the given entity has a primary key assigned (the primary key is not null). Always returns true if the primary key is a non-nullable value type.
        /// </summary>
        /// <returns></returns>
        public Func<TEntity, bool> HasPrimaryKey { get; private set; }
    }
}
