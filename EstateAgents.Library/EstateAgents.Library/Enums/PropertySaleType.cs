using System.ComponentModel;

namespace EstateAgents.Library.Enums
{
    /// <summary>
    /// The enumeration for the property sale type
    /// </summary>
    public enum PropertySaleType
    {
        /// <summary>
        /// Enum for Buy
        /// </summary>
        [Description("Buy")]
        Buy,

        /// <summary>
        /// Enum for Rent
        /// </summary>
        [Description("Rent")]
        Rent
    };
}
