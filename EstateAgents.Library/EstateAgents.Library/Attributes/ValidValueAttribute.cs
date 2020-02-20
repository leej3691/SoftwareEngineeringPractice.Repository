using System;

namespace EstateAgents.Library.Attributes
{
    /// <summary>
    /// Used to determine that the value of the property is qual to the value specific on the attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ValidValueAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        // Local Properties
        private string _setvalue;

        /// <summary>
        /// The value we want the property value to equal
        /// </summary>
        public string SetValue
        {
            get { return _setvalue; }
        }

        /// <summary>
        /// Defauly constructor
        /// </summary>
        /// <param name="setvalue">The value we want the property value to equal</param>
        public ValidValueAttribute(string setvalue)
        {
            _setvalue = setvalue;
        }

        /// <summary>
        /// Validates the attribute
        /// </summary>
        /// <param name="value">Value of the property</param>
        public override bool IsValid(object value)
        {
            return value != null && SetValue.Equals(value.ToString(), StringComparison.OrdinalIgnoreCase);
        }

    }
}
