using System.ComponentModel.DataAnnotations;
using EstateAgents.Library.Helpers;
using System;

namespace EstateAgents.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ValidMobileAttribute : ValidationAttribute
    {

        /// <summary>
        /// Tests if the value is a valid mobile number
        /// </summary>
        public override bool IsValid(object value)
        {
            return (value == null) || (value != null && ValidationHelper.IsMobileNumber(value.ToString()));
        }
    }
}
