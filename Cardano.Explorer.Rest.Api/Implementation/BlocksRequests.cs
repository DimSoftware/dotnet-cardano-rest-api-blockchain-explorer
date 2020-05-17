using Cardano.Core;
using Cardano.Explorer.Rest.Api.Common;
using Cardano.Explorer.Rest.Api.Models;
using Cardano.Http;
using Cardano.Models.Common;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cardano.Explorer.Rest.Api.Implementation
{
	public class BlocksRequests
	{
		/// <summary>
		/// Get the list of blocks, contained in pages.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<BlockPage>>> GetBlocksAsync(
			uint page,
			uint pageSize)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Blocks,
				PathConstants.Pages));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(page), page);
			queryParams.Add(nameof(pageSize), pageSize);

			path.Append(queryParams.ToQueryString());

			var response = await GetRequest.GetAsync<Right<List<object>>>(path.ToString());
			var result = ResponseExtensions.Merge<BlockPage, List<object>>(response);

			return result;
		}

		/// <summary>
		/// Get the list of total pages.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<ulong>>> GetTotalPagesAsync(
			uint pageSize)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Blocks,
				PathConstants.Pages,
				PathConstants.Total));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(pageSize), pageSize);

			path.Append(queryParams.ToQueryString());

			return await GetRequest.GetAsync<Right<ulong>>(path.ToString());
		}

		/// <summary>
		/// Get block's summary information.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<BlockSummaryInformation>>> GetBlockSummaryAsync(
			string blockHash)
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Blocks, 
				PathConstants.Summary,
				blockHash);

			return await GetRequest.GetAsync<Right<BlockSummaryInformation>>(path);
		}

		/// <summary>
		/// Get brief information about transactions.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<IEnumerable<Transaction>>>> GetTransactionsAsync(
			string blockHash,
			ulong limit, 
			ulong offset)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Blocks,
				PathConstants.Txs,
				blockHash));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(limit), limit);
			queryParams.Add(nameof(offset), offset);

			path.Append(queryParams.ToQueryString());

			return await GetRequest.GetAsync<Right<IEnumerable<Transaction>>>(path.ToString());
		}
	}
}
