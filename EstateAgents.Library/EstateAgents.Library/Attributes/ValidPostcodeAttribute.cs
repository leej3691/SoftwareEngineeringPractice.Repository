using System;
using EstateAgents.Library.Helpers;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.Library.Attributes
{
    /// <summary>
    /// Checks if the value specified is a match for the required validation of the UK Postcode
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ValidPostcodeAttribute : ValidationAttribute
    {
        /// <summary>
        /// Tests if the value is a valid postcode
        /// </summary>
        public override bool IsValid(object value)
        {
            return (value == null) || (value != null && ValidationHelper.IsPostcode(value.ToString()));
        }
    }
}
