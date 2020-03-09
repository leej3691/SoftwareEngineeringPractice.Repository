using System.ComponentModel;

namespace EstateAgents.Library.Enums
{
    /// <summary>
    /// The enumeration for the property viewing type
    /// </summary>
    public enum PropertyViewingStatus
    {
        /// <summary>
        /// Enum for Pending
        /// </summary>
        [Description("Pending")]
        Pending,

        /// <summary>
        /// Enum for Scheduled
        /// </summary>
        [Description("Scheduled")]
        Scheduled,

        /// <summary>
        /// Enum for Attended
        /// </summary>
        [Description("Attended")]
        Attended,

        /// <summary>
        /// Enum for Rejected
        /// </summary>
        [Description("Rejected")]
        Rejected,

        /// <summary>
        /// Enum for Cancelled
        /// </summary>
        [Description("Cancelled")]
        Cancelled
    };
}
