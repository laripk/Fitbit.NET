using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fitbit.Api.Portable.OAuth2;


namespace Fitbit.Api.Portable
{
    public interface ITokenStore 
    { 
        string Read();  //shouldn't this return OAuth2AccessToken ??

		void Write(OAuth2AccessToken token); 
    } 
}