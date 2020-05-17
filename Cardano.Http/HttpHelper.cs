using Cardano.Core;
using System;

namespace Cardano.Http
{
	public class HttpHelper
	{
		public static Uri NodeUrlFormat(string path)
			=> new Uri($"{CardanoNode.Url}{path}");

		public static string UrlCombine(params object[] pathParams)
			=> string.Join("/", pathParams);
	}
}
