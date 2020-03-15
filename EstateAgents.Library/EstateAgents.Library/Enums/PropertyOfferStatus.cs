using System.ComponentModel;

namespace EstateAgents.Library.Enums
{
    /// <summary>
    /// The enumeration for the property offer status
    /// </summary>
    public enum PropertyOfferStatus
    {
        /// <summary>
        /// Enum for Pending
        /// </summary>
        [Description("Pending")]
        Pending,

        /// <summary>
        /// Enum for Accepted
        /// </summary>
        [Description("Accepted")]
        Accepted,

        /// <summary>
        /// Enum for Rejected
        /// </summary>
        [Description("Rejected")]
        Rejected,

        /// <summary>
        /// Enum for Withdrawn
        /// </summary>
        [Description("Withdrawn")]
        Withdrawn

    };
}
