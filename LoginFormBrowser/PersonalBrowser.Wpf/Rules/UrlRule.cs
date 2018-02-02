using System;
using System.Globalization;
using System.Windows.Controls;

namespace PersonalBrowser.Wpf.Rules
{
    public class UrlRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Uri address;
            if (Uri.TryCreate((string)value, UriKind.Absolute, out address))
            {
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false, "Недопустимые символы.");
        }
    }
}
