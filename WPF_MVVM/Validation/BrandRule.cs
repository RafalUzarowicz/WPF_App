using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_MVVM.Validation
{
    class BrandRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value.ToString().Count() > 0)
            {
                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Brand can't be empty.");
        }
    }
}
