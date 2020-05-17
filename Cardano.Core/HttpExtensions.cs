using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cardano.Core
{
    public static class HttpExtensions
    {
		public static string ToQueryString(this IDictionary<string, object> queryParams)
		{
			var queryString = new StringBuilder();

			foreach (var kvp in queryParams)
			{
				if (queryParams.First().Key == kvp.Key)
				{
					queryString.Append("?");
				}

				queryString.AppendFormat($"{kvp.Key}={kvp.Value}");

				if (queryParams.ElementAt(queryParams.Count() - 1).Key != kvp.Key)
				{
					queryString.Append("&");
				}
			}

			return queryString.ToString();
		}
	}
}
