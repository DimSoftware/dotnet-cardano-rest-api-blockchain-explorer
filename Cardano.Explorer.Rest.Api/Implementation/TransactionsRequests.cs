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
	public class TransactionsRequests
	{
		/// <summary>
		/// Get brief information about transactions.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<IEnumerable<TransactionInformation>>>> GetTransactionsAsync()
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Txs,
				PathConstants.Last);

			return await GetRequest.GetAsync<Right<IEnumerable<TransactionInformation>>>(path);
		}

		/// <summary>
		/// Get summary information about a transaction.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<TransactionSummaryInformation>>> GetTransactionInformationSummaryAsync(
			string txId)
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Txs,
				PathConstants.Summary, 
				txId);

			return await GetRequest.GetAsync<Right<TransactionSummaryInformation>>(path);
		}

		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<TransactionStatsPage>>> GetTransactionsStatsAsync(
			uint page)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Stats,
				PathConstants.Txs));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(page), page);

			path.Append(queryParams.ToQueryString());

			var response = await GetRequest.GetAsync<Right<List<object>>>(path.ToString());
			var result = ResponseExtensions.Merge<TransactionStatsPage, List<object>>(response);

			return result;
		}
	}
}
