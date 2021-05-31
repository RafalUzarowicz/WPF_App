using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_MVVM.Validation
{
    class MaxSpeedRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value.ToString().Count() == 0)
            {
                return new ValidationResult(false, "Field can't be empty.");
            }
            int maxSpeed;
            try
            {
                maxSpeed = int.Parse(value.ToString());
            }
            catch (FormatException)
            {
                return new ValidationResult(false, "Field must be a number.");
            }

            return ValidationResult.ValidResult;
        }
    }
}
