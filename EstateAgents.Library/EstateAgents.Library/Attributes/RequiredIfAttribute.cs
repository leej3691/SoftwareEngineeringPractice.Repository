using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System;

namespace EstateAgents.Library.Attributes
{
    /// <summary>
    /// Used to set the requirement of a property based on the dependancy property and the values
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class RequiredIfAttribute : ValidationAttribute
    {

        // Local Properties
        private string _dependancy;
        private object[] _targetValues;

        /// <summary>
        /// The name of property this will be dependant on
        /// </summary>
        public string Dependancy
        {
            get { return _dependancy; }
        }

        /// <summary>
        /// The values on the dependancy property to set this to required
        /// </summary>
        public object[] TargetValues
        {
            get { return _targetValues; }
        }

        /// <summary>
        /// Defauly constructor
        /// </summary>
        /// <param name="dependancy">The name of the property this is dependant on</param>
        /// <param name="targetValues">The values on the dependancy property that will trigger the requirement</param>
        public RequiredIfAttribute(string dependancy, object[] targetValues)
        {
            _dependancy = dependancy;
            _targetValues = targetValues;
        }

        /// <summary>
        /// Confirms if the case ID value specified and the property value match
        /// </summary>
        /// <param name="value">Value of the validation code</param>
        /// <param name="validationContext">The context of the validation</param>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            // We only check if the target value is not null
            if (TargetValues == null && TargetValues.Count() > 0)
                return ValidationResult.Success;

            // Get a reference to the property this validation depends upon - errors if the property doesn't exist
            var propertyName = validationContext.ObjectType.GetProperty(Dependancy);
            if (propertyName == null)
            {
                //TODO: Add logging
                return new ValidationResult(string.Format(CultureInfo.CurrentCulture, ErrorMessage));
            }

            // If the value of the dependancy property is blank we don't need to validate
            var propertyValue = propertyName.GetValue(validationContext.ObjectInstance, null);
            if (propertyValue == null)
                return ValidationResult.Success;

            // Compare the value against the target values and if any are equal then the property is required - so check if the value is blank
            if (TargetValues.Where(i => i.Equals(propertyValue)).Count() > 0 && (value == null || value.ToString() == ""))
                return new ValidationResult(ErrorMessage);

            // If everything above has passed this property isn't required
            return ValidationResult.Success;

        }

    }
}
