﻿namespace Fitbit.Api.Portable.OAuth2
{
	using System;
	using System.Collections.Generic;
	using System.Net.Http;
	using System.Threading.Tasks;

	internal class DefaultTokenManager : AbstractTokenManager
	{
		protected override void PostRefreshToken(FitbitClient client, OAuth2AccessToken token)
		{ }

		protected override void PreRefreshToken(FitbitClient client)
		{ }


	}
}
