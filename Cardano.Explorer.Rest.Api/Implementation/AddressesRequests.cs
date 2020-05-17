using Cardano.Explorer.Rest.Api.Common;
using Cardano.Explorer.Rest.Api.Models;
using Cardano.Http;
using Cardano.Models.Common;
using System.Threading.Tasks;

namespace Cardano.Explorer.Rest.Api.Implementation
{
	public class AddressesRequests
	{
		/// <summary>
		/// Get summary information about an address.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<Address>>> GetAddressSummaryAsync(
			string address)
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Addresses,
				PathConstants.Summary,
				address);

			return await GetRequest.GetAsync<Right<Address>>(path);
		}

		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<Address>>> GetAddressAsync(
			string blockHash,
			string address)
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api, 
				PathConstants.Block,
				blockHash,
				PathConstants.Address,
				address);

			return await GetRequest.GetAsync<Right<Address>>(path);
		}
	}
}
