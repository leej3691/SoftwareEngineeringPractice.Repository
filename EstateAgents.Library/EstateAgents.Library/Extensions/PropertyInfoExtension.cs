using System.ComponentModel.DataAnnotations;
using EstateAgents.Library.Attributes;
using System.Reflection;
using System;

namespace EstateAgents.Library.Extensions
{
    public static class PropertyInfoExtension
    {

        /// <summary>
        /// Checks if the {RequiredIfAttribute} exists for the property
        /// </summary>
        public static bool CheckIfRequiredIfAttributeExists(this PropertyInfo property)
        {
            return property != null && Attribute.IsDefined(property, typeof(RequiredIfAttribute));
        }

        /// <summary>
        /// Get the properties {RequiredIfAttribute} attribute
        /// </summary>
        public static RequiredIfAttribute RequiredIfAttribute(this PropertyInfo property)
        {
            return CheckIfRequiredIfAttributeExists(property) ? property.GetCustomAttribute<RequiredIfAttribute>(true) : null;
        }

        /// <summary>
        /// Get the properties {UIHintAttribute} attribute
        /// </summary>
        public static UIHintAttribute UIHintAttributeAttribute(this PropertyInfo property)
        {
            return CheckIfUIHintAttributeExists(property) ? property.GetCustomAttribute<UIHintAttribute>(true) : null;
        }

        /// <summary>
        /// Checks if the {MaxLengthAttribute} exists for the property
        /// </summary>
        public static bool CheckIfMaxLengthAttributeExists(this PropertyInfo property)
        {
            return property != null && Attribute.IsDefined(property, typeof(MaxLengthAttribute));
        }

        /// <summary>
        /// Checks if the {StringLength} exists for the property
        /// </summary>
        public static bool CheckIfStringLengthAttributeExists(this PropertyInfo property)
        {
            return property != null && Attribute.IsDefined(property, typeof(StringLengthAttribute));
        }

        /// <summary>
        /// Checks if the {ValidValueAttribute} exists for the property
        /// </summary>
        public static bool CheckIfValidValueAttributeExists(this PropertyInfo property)
        {
            return property != null && Attribute.IsDefined(property, typeof(ValidValueAttribute));
        }

        /// <summary>
        /// Checks if the {MutedTextAttribute} exists for the property
        /// </summary>
        public static bool CheckIfMutedTextAttributeExists(this PropertyInfo property)
        {
            return property != null && Attribute.IsDefined(property, typeof(MutedTextAttribute));
        }

        /// <summary>
        /// Checks if the {UIHintAttribute} exists for the property
        /// </summary>
        public static bool CheckIfUIHintAttributeExists(this PropertyInfo property)
        {
            return property != null && Attribute.IsDefined(property, typeof(UIHintAttribute));
        }

        /// <summary>
        /// Get the properties {MaxLengthAttribute} attribute
        /// </summary>
        public static MaxLengthAttribute MaxLengthAttribute(this PropertyInfo property)
        {
            return CheckIfMaxLengthAttributeExists(property) ? property.GetCustomAttribute<MaxLengthAttribute>(true) : null;
        }

        /// <summary>
        /// Get the properties {StringLengthAttribute} attribute
        /// </summary>
        public static StringLengthAttribute StringLengthAttribute(this PropertyInfo property)
        {
            return CheckIfStringLengthAttributeExists(property) ? property.GetCustomAttribute<StringLengthAttribute>(true) : null;
        }

        /// <summary>
        /// Get the properties {ValidValueAttribute} attribute
        /// </summary>
        public static ValidValueAttribute ValidValueAttribute(this PropertyInfo property)
        {
            return CheckIfValidValueAttributeExists(property) ? property.GetCustomAttribute<ValidValueAttribute>(true) : null;
        }

        /// <summary>
        /// Get the properties {MutedTextAttribute} attribute
        /// </summary>
        public static MutedTextAttribute MutedTextAttribute(this PropertyInfo property)
        {
            return CheckIfMutedTextAttributeExists(property) ? property.GetCustomAttribute<MutedTextAttribute>(true) : null;
        }

    }
}
