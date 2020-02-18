namespace EstateAgents.Library.Helpers
{
    /// <summary>
    /// Regular Expression Helper
    /// </summary>
    public sealed class RegularExpressionHelper
    {
        /// <summary>
        /// Provides a regular expression to test a value for an Email Address 
        /// </summary>

        public const string EmailAddress = @"^((([!#$%&'*+\-/=?^_`{|}~\w])|([!#$%&'*+\-/=?^_`{|}~\w][!#$%&'*+\-/=?^_`{|}~\.\w]{0,}[!#$%&'*+\-/=?^_`{|}~\w]))[@]\w+([-.]\w+)*\.\w+([-.]\w+)*)$";

        /// <summary>
        /// Provides a regular expression to test a value for an Mobile Number
        /// </summary>

        public const string MobileNumber = "^(\\+44\\s?7\\d{3}|\\(?07\\d{3}\\)?)\\s?\\d{3}\\s?\\d{3}$";

        /// <summary>
        /// Provides a regular expression to test a value for a UK Postcode
        /// </summary>

        public const string Postcode = "^(([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2}))$";

        /// <summary>
        /// Provides a regular expression to test a value for a time of HH@MM
        /// </summary>

        public const string Time = "^([0-1][0-9]|[2][0-3]):([0-5][0-9])$";
    }
}
