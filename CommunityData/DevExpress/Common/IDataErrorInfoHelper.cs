using System.Collections;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace DevExpress.Common
{
    public static class IDataErrorInfoHelper
    {
        public static string GetErrorText(object owner, string propertyName)
        {
            string[] path = propertyName.Split('.');
            if (path.Length > 1)
                return IDataErrorInfoHelper.GetErrorText(owner, path);
            PropertyInfo property = owner.GetType().GetProperty(propertyName);
            if (property == (PropertyInfo)null)
                return (string)null;
            object propertyValue = property.GetValue(owner, (object[])null);
            ValidationContext validationContext = new ValidationContext(owner, (IServiceProvider)null, (IDictionary<object, object>)null)
            {
                MemberName = propertyName
            };
            return string.Join(" ", Enumerable.ToArray<string>(Enumerable.Where<string>(Enumerable.Select<ValidationResult, string>(Enumerable.Where<ValidationResult>(Enumerable.Select<ValidationAttribute, ValidationResult>(Enumerable.OfType<ValidationAttribute>((IEnumerable)property.GetCustomAttributes(false)), (Func<ValidationAttribute, ValidationResult>)(x => x.GetValidationResult(propertyValue, validationContext))), (Func<ValidationResult, bool>)(x => x != null)), (Func<ValidationResult, string>)(x => x.ErrorMessage)), (Func<string, bool>)(x => !string.IsNullOrEmpty(x)))));
        }

        private static string GetErrorText(object owner, string[] path)
        {
            string index = string.Join(".", Enumerable.Skip<string>((IEnumerable<string>)path, 1));
            string name = path[0];
            PropertyInfo property = owner.GetType().GetProperty(name);
            if (property == (PropertyInfo)null)
                return (string)null;
            IDataErrorInfo dataErrorInfo = property.GetValue(owner, (object[])null) as IDataErrorInfo;
            if (dataErrorInfo != null)
                return dataErrorInfo[index];
            return string.Empty;
        }
    }

}