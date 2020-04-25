using System.ComponentModel;

namespace EstateAgents.Library.Enums
{
    /// <summary>
    /// The enumeration for the property type
    /// </summary>
    public enum PropertyType
    {
        /// <summary>
        /// Enum for Terraced
        /// </summary>
        [Description("Terraced")]
        Terraced,

        /// <summary>
        /// Enum for Semi-Detached
        /// </summary>
        [Description("Semi-Detached")]
        SemiDetached,

        /// <summary>
        /// Enum for Detached
        /// </summary>
        [Description("Detached")]
        Detached,

        /// <summary>
        /// Enum for Bugalow
        /// </summary>
        [Description("Bungalow")]
        Bungalow,

        /// <summary>
        /// Enum for Flat
        /// </summary>
        [Description("Flat")]
        Flat,

        /// <summary>
        /// Enum for Apartment
        /// </summary>
        [Description("Apartment")]
        Apartment,
    };
}
