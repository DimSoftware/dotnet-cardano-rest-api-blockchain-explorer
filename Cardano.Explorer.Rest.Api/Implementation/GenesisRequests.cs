using Cardano.Core;
using Cardano.Explorer.Rest.Api.Models;
using Cardano.Http;
using Cardano.Models.Common;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cardano.Core.Nomenclatures;
using Cardano.Explorer.Rest.Api.Common;

namespace Cardano.Explorer.Rest.Api.Implementation
{
	public class GenesisRequests
	{
		/// <summary>
		/// Get information about the genesis block.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<GenesisBlock>>> GetSummaryAsync()
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Genesis,
				PathConstants.Summary);

			return await GetRequest.GetAsync<Right<GenesisBlock>>(path);
		}

		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<ulong>>> GetTotalPagesAsync(
			uint pageSize,
			FilterEnum filter)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Genesis,
				PathConstants.Address,
				PathConstants.Pages,
				PathConstants.Total));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(pageSize), pageSize);
			queryParams.Add(nameof(filter), filter.GetValue());

			path.Append(queryParams.ToQueryString());

			return await GetRequest.GetAsync<Right<ulong>>(path.ToString());
		}

		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<IEnumerable<GenesisAddress>>>> GetAddressInfoAsync(
			uint page,
			uint pageSize,
			FilterEnum filter)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Genesis,
				PathConstants.Address));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(page), page);
			queryParams.Add(nameof(pageSize), pageSize);
			queryParams.Add(nameof(filter), filter.GetValue());

			path.Append(queryParams.ToQueryString());

			return await GetRequest.GetAsync<Right<IEnumerable<GenesisAddress>>>(path.ToString());
		}

		/// <summary>
		/// Get the total supply of Ada.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<decimal>>> GetTotalAdaSupplyAsync()
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Supply,
				PathConstants.Ada);

			return await GetRequest.GetAsync<Right<decimal>>(path);
		}
	}
}
