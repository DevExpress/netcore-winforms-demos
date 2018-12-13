using System;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Collections.ObjectModel;
using DevExpress.DevAV.Common.Utils;
using DevExpress.Mvvm.DataModel;

namespace DevExpress.DevAV.Common.ViewModel {
    /// <summary>
    /// Represents a POCO view models used by SingleObjectViewModel to exposing collections of related entities.
    /// This is a partial class that provides an extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">A repository entity type.</typeparam>
    /// <typeparam name="TProjection">A projection entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public class LookUpEntitiesViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork> : EntitiesViewModel<TEntity, TProjection, TUnitOfWork>, IDocumentContent
        where TEntity : class
        where TProjection : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Creates a new instance of LookUpEntitiesViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        public static LookUpEntitiesViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork> Create(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection = null) {
            return ViewModelSource.Create(() => new LookUpEntitiesViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection));
        }

        /// <summary>
        /// Initializes a new instance of the LookUpEntitiesViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the LookUpEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        protected LookUpEntitiesViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection) {
        }

        protected override IEntitiesChangeTracker CreateEntitiesChangeTracker() {
            return new EntitiesChangeTracker<TPrimaryKey>(this);
        }
    }
}