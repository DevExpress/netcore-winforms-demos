using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

// This demo targets .NET Framework 4.0. A number of validation attributes that exist in .NET Framework 4.5 cannot be used.
// That is why we have created our own counterparts of these attributes for this demo.
// If your application targets .NET Framework 4.5, use default validation attributes.
// If your application targets .NET Framework 4.0, you can copy and use these attributes or use DevExpress Validation Fluent API instead.

namespace DevExpress.DataAnnotations {
    public abstract class RegexAttributeBase : DataTypeAttribute {
        protected const RegexOptions DefaultRegexOptions = RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase;

        readonly Regex regex;

        public RegexAttributeBase(string regex, string defaultErrorMessage, DataType dataType)
            : this(new Regex(regex, DefaultRegexOptions), defaultErrorMessage, dataType) {
        }
        public RegexAttributeBase(Regex regex, string defaultErrorMessage, DataType dataType)
            : base(dataType) {
            this.regex = (Regex)regex;
            this.ErrorMessage = defaultErrorMessage;
        }
        public sealed override bool IsValid(object value) {
            if(value == null)
                return true;
            string input = value as string;
            return input != null && regex.Match(input).Length > 0;
        }
    }
    public sealed class ZipCodeAttribute : RegexAttributeBase {
        static Regex regex = new Regex(@"^[0-9][0-9][0-9][0-9][0-9]$", DefaultRegexOptions);
        const string Message = "The {0} field is not a valid ZIP code.";
        public ZipCodeAttribute()
            : base(regex, Message, DataType.Url) {
        }
    }
    public sealed class CreditCardAttribute : DataTypeAttribute {
        const string Message = "The {0} field is not a valid credit card number.";
        public CreditCardAttribute()
            : base(DataType.Custom) {
            this.ErrorMessage = Message;
        }
        public override bool IsValid(object value) {
            if(value == null)
                return true;
            string stringValue = value as string;
            if(stringValue == null)
                return false;
            stringValue = stringValue.Replace("-", "").Replace(" ", "");
            int number = 0;
            bool oddEvenFlag = false;
            foreach(char ch in stringValue.Reverse()) {
                if(ch < '0' || ch > '9')
                    return false;
                int digitValue = (ch - '0') * (oddEvenFlag ? 2 : 1);
                oddEvenFlag = !oddEvenFlag;
                while(digitValue > 0) {
                    number += digitValue % 10;
                    digitValue = digitValue / 10;
                }
            }
            return (number % 10) == 0;
        }
    }
}