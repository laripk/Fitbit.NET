namespace Fitbit.Api.Portable
{
    internal class Constants
    {
        public const string BaseApiUrl = "https://api.fitbit.com/";

		#region oauth2 stuff
		public const string FitbitOauthPostUrl = "https://api.fitbit.com/oauth2/token";
		#endregion

		#region oauth1 stuff
		public const string TemporaryCredentialsRequestTokenUri = "oauth/request_token";
        public const string TemporaryCredentialsAccessTokenUri = "oauth/access_token";
        public const string AuthorizeUri = "oauth/authorize";
        public const string LogoutAndAuthorizeUri = "oauth/logout_and_authorize";
		#endregion

		public class Headers
        {
            public const string XFitbitSubscriberId = "X-Fitbit-Subscriber-Id";   
        }

        public class Formatting
        {
            public const string TrailingSlash = "{0}/";
            public const string LeadingDash = "-{0}";
        }
    }
}
