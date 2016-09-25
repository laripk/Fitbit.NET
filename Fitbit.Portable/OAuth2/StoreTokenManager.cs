
namespace Fitbit.Api.Portable.OAuth2
{
	using System;
	using System.Collections.Generic;
	using System.Net.Http;
	using System.Threading.Tasks;
	
	public class StoreTokenManager : AbstractTokenManager
	{
		protected ITokenStore Store;

		public StoreTokenManager(ITokenStore store)
		{
			Store = store;
		}

		protected override void PostRefreshToken(FitbitClient client, OAuth2AccessToken token)
		{
			Store.Write(token);
		}

		protected override void PreRefreshToken(FitbitClient client)
		{ }


	}
}
