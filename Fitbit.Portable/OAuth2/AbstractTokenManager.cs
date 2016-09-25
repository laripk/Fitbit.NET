namespace Fitbit.Api.Portable.OAuth2
{
	using System.Collections.Generic;
	using System.Net.Http;
	using System.Threading.Tasks;

	public abstract class AbstractTokenManager : ITokenManager
	{
		protected abstract void PreRefreshToken(FitbitClient client);

		protected abstract void PostRefreshToken(FitbitClient client, OAuth2AccessToken token);

		public async Task<OAuth2AccessToken> RefreshTokenAsync(FitbitClient client)
		{
			PreRefreshToken(client);//maybe move after addsecret

			string postUrl = Constants.FitbitOauthPostUrl;
			var content = client.BuildRefreshFormContent();
			var httpClient = new HttpClient();
			OAuth2Helper.AddSecretToAuthHeader(httpClient, client.AppCredentials);

			HttpResponseMessage response = await httpClient.PostAsync(postUrl, content);
			string responseString = await response.Content.ReadAsStringAsync();
			var token = OAuth2Helper.ParseAccessTokenResponse(responseString);

			PostRefreshToken(client, token);

			return token;
		}
	}
}
