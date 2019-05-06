using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DevExpress.DevAV.Reports {
    static class EnumDisplayTextHelper {
        public static string GetDisplayText(object value) {
            MemberInfo[] info = value.GetType().GetMember(value.ToString());
            object[] attributes = info[0].GetCustomAttributes(false);
            for(int i = 0; i < attributes.Length; i++) {
                Type attributeType = attributes[i].GetType();
                if(attributeType == typeof(System.ComponentModel.DataAnnotations.DisplayAttribute))
                    return (string)attributeType.GetProperty("Name").GetValue(attributes[i], null) ?? string.Empty;
            }
            return value.ToString();
        }
    }
}
