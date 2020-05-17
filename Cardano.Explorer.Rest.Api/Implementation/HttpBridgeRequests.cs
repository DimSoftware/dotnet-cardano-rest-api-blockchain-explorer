using Cardano.Explorer.Rest.Api.Models;
using Cardano.Http;
using Cardano.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cardano.Core.Nomenclatures;
using Cardano.Explorer.Rest.Api.Common;

namespace Cardano.Explorer.Rest.Api.Implementation
{
	public class HttpBridgeRequests
	{
		/// <summary>
		/// Get current balance of provided address.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<IEnumerable<AddressBalance>>> GetAddressBalanceAsync(
			NetworkEnum network,
			string address)
		{
			var path = HttpHelper.UrlCombine(
				network.GetValue(),
				PathConstants.Utxos,
				address);

			return await GetRequest.GetAsync<IEnumerable<AddressBalance>>(path);
		}
	}
}
