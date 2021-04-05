using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OneNX.WPF.Demo.ValidationRule
{
	public class ageValidation : System.Windows.Controls.ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			try
			{
				var age = Convert.ToInt32(value);
				if (age < 9 || age > 100)
				{
					return new ValidationResult(false, "Out of range.");
				}
				return ValidationResult.ValidResult;
			}
			catch (Exception)
			{
				return new ValidationResult(false, "Age must be an integer.");
			}
			
		}
	}
}
