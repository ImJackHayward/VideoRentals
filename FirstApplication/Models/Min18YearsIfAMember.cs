using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            
            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouyGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            if (age == 18)
            {
                var days = DateTime.Today - new DateTime(DateTime.Today.Year, customer.Birthdate.Value.Month, customer.Birthdate.Value.Day);
                if (days.TotalDays < 0.0)
                    age--;
            }

            return (age >= 18)

                ? ValidationResult.Success
                : new ValidationResult("Customer must be at least 18 to have a membership");
        }
    }
}