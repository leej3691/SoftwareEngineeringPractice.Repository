using System;
using EstateAgents.Library.Helpers;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.Library.Attributes
{
    /// <summary>
    /// Checks if the value specified is a valid email address
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ValidEmailAttribute : ValidationAttribute
    {

        /// <summary>
        /// Tests if the value is a valid Email Address
        /// </summary>
        public override bool IsValid(object value)
        {
            return (value == null) || (value != null && ValidationHelper.IsEmailAddress(value.ToString()));
        }
    }
}
