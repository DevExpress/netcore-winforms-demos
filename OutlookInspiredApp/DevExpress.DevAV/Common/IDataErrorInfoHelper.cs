using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace DevExpress.Common {
    public static class IDataErrorInfoHelper {
        public static string GetErrorText(object owner, string propertyName) {
            string[] path = propertyName.Split('.');
            if(path.Length > 1)
                return GetErrorText(owner, path);
            PropertyInfo propertyInfo = owner.GetType().GetProperty(propertyName);
            if (propertyInfo == null) return null;
            object propertyValue = propertyInfo.GetValue(owner, null);
            ValidationContext validationContext = new ValidationContext(owner, null, null) { MemberName = propertyName };
            string[] errors = propertyInfo
                .GetCustomAttributes(false)
                .OfType<ValidationAttribute>()
                .Select(x => x.GetValidationResult(propertyValue, validationContext))
                .Where(x => x != null)
                .Select(x => x.ErrorMessage)
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();
            return string.Join(" ", errors);
        }
        static string GetErrorText(object owner, string[] path) {
            string nestedPropertyName = string.Join(".", path.Skip(1));
            string propertyName = path[0];
            PropertyInfo propertyInfo = owner.GetType().GetProperty(propertyName);
            if(propertyInfo == null)
                return null;
            object propertyValue = propertyInfo.GetValue(owner, null);
            IDataErrorInfo nestedDataErrorInfo = propertyValue as IDataErrorInfo;
            return nestedDataErrorInfo == null ? string.Empty : nestedDataErrorInfo[nestedPropertyName];
        }
    }
}