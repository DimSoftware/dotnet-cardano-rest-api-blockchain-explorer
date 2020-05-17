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
	public class EpochsRequests
	{
		/// <summary>
		/// Get epoch pages, all the paged slots in the epoch.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<BlockPage>>> GetEpochAsync(
			ulong epoch,
			uint page)
		{
			var path = new StringBuilder(HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Epochs,
				epoch));

			var queryParams = new Dictionary<string, object>();
			queryParams.Add(nameof(page), page);

			path.Append(queryParams.ToQueryString());

			var response = await GetRequest.GetAsync<Right<List<object>>>(path.ToString());
			var result = ResponseExtensions.Merge<BlockPage, List<object>>(response);

			return result;
		}


		/// <summary>
		/// Get the slot information in an epoch.
		/// </summary>
		/// <responseCode>200 Ok</responseCode>
		public async Task<Response<Right<IEnumerable<Block>>>> GetTotalPagesAsync(
			ulong epoch,
			ushort slot)
		{
			var path = HttpHelper.UrlCombine(
				PathConstants.Api,
				PathConstants.Epochs, 
				epoch, 
				slot);

			return await GetRequest.GetAsync<Right<IEnumerable<Block>>>(path);
		}
	}
}
