using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using DevExpress.DataAnnotations;

namespace DevExpress.DevAV.Common.Utils {
    public static class DataAnnotationHelper {
        public static bool IsRequired<TEntity>(string propertyName) {
            return IsSet<RequiredAttribute>(typeof(TEntity), propertyName);
        }
        public static bool IsPhone<TEntity>(string propertyName) {
            return IsSet<PhoneAttribute>(typeof(TEntity), propertyName);
        }
        public static bool IsEmail<TEntity>(string propertyName) {
            return IsSet<EmailAddressAttribute>(typeof(TEntity), propertyName);
        }
        public static bool IsZipcode<TEntity>(string propertyName) {
            return IsSet<ZipCodeAttribute>(typeof(TEntity), propertyName);
        }
        public static bool IsSet<TAttribute>(System.Type type, string propertyName) where TAttribute : ValidationAttribute {
            string[] path = propertyName.Split('.');
            if(path.Length > 1) {
                PropertyInfo nestedPropertyInfo = type.GetProperty(path[0]);
                if(nestedPropertyInfo == null)
                    return false;
                return IsSet<TAttribute>(nestedPropertyInfo.PropertyType, string.Join(".", path.Skip(1)));
            }
            PropertyInfo propertyInfo = type.GetProperty(propertyName);
            if(propertyInfo == null)
                return false;
            return propertyInfo.GetCustomAttributes(false).OfType<TAttribute>().Any();
        }
    }
}