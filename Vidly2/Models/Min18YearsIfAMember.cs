using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if(customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if(customer.BirthdayDate == null)
                return new ValidationResult("Birthdate is required");

            return (DateTime.Now.Year - customer.BirthdayDate.Value.Year > 18)
                ? ValidationResult.Success
                : new ValidationResult("User must be over 18 years age");
        }
    }
}