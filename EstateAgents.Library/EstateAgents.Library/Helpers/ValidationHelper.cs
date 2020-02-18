using System.Text.RegularExpressions;

namespace EstateAgents.Library.Helpers
{
    /// <summary>
    /// Validation Helper
    /// </summary>
    public class ValidationHelper
    {
        /// <summary>
        /// Checks to see if the email address is valid
        /// </summary>
        /// <param name="email">The email to be validated</param>
        public static bool IsEmailAddress(string email)
        {
            // Checks we have an email address
            if (email != null)
            {
                // Whole Email Cannot Be Longer Than 254
                if (email.Length > 254)
                    return false;

                // Create reg ex function
                Regex re = new Regex(RegularExpressionHelper.EmailAddress);

                // Check the email is actually in the correct format
                return re.IsMatch(email);
            }

            return false;

        }

        /// <summary>
        /// Checks if the input string is a valid Mobile Number
        /// </summary>
        public static bool IsMobileNumber(string Mobile)
        {
            Regex re = new Regex(RegularExpressionHelper.MobileNumber);
            return re.IsMatch(Mobile);
        }

        /// <summary>
        /// Tests if the value specified is a match for the required validation of the UK Postcode
        /// </summary>
        public static bool IsPostcode(string postcode)
        {
            // Checks we have a postcode
            if (string.IsNullOrEmpty(postcode))
                return false;

            // Create reg ex function
            Regex r = new Regex(RegularExpressionHelper.Postcode);

            // Check the email is in the correct format
            return r.Match(postcode).Success;
        }
    }
}
