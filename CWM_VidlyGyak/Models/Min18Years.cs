using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CWM_VidlyGyak.Models
{
    public class Min18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var custumer = (Custumer)validationContext.ObjectInstance;

            if (custumer.MembershipTypeId == MembershipType.Unknown || custumer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (custumer.Birthdate == null)
                return new ValidationResult("Birthdate is required!");

            var age = DateTime.Now.Year - custumer.Birthdate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old to go on a membership");
        }
    }
}

