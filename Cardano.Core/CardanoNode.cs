using System;

namespace Cardano.Core
{
	public class CardanoNode
	{
		public CardanoNode(Uri nodeUrl)
		{
			Url = nodeUrl;
		}

		public static Uri Url { get; private set; }

		public static bool IsValidUrl(string url)
			=> Uri.IsWellFormedUriString(url, UriKind.Absolute);
	}
}
