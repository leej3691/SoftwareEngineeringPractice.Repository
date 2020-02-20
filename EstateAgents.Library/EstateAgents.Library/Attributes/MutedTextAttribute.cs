using System;

namespace EstateAgents.Library.Attributes
{
    /// <summary>
    /// Used to pass in muted text on the properties UIHint template
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class MutedTextAttribute : System.ComponentModel.DescriptionAttribute
    {

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="description">The description we want the muted text to be</param>
        public MutedTextAttribute(string description)
        {
            DescriptionValue = description;
        }

    }
}
