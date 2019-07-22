using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalShp.Filter
{
    public class DateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {
            if (((DateTime)value).Subtract(DateTime.Today).Days < 30)
                return new ValidationResult("Incorrect expiry date");
            return ValidationResult.Success;
        }
    }
}