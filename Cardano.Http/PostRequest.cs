using Cardano.Models.Common;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cardano.Http
{
	public class PostRequest
	{
		public static async Task<Response<R>> PostAsync<R, D>(
			string path,
			D data,
			string mediaTypeOverride = null)
			where R : class
			where D : class
		{
			var httpClient = new HttpClient();
			var requestMediaType = Constants.mediaType;

			if (!string.IsNullOrEmpty(mediaTypeOverride))
			{
				requestMediaType = mediaTypeOverride;
			}

			httpClient.DefaultRequestHeaders
				.Accept
				.Add(new MediaTypeWithQualityHeaderValue(requestMediaType));

			var dataAsString = string.Empty;

			if (typeof(D) == typeof(string))
			{
				dataAsString = data as string;
			}
			else
			{
				dataAsString = Json.JsonExtensions.Serialize(data);
			}

			var httpContent = new StringContent(dataAsString);
			var httpResponse = await httpClient.PostAsync(HttpHelper.NodeUrlFormat(path), httpContent);

			var contentStream = await httpResponse.Content.ReadAsStreamAsync();

			var response = new Response<R>();

			var error = await Json.JsonExtensions.DeserializeAsync<HttpResponseModel>(contentStream);

			if (error != null)
			{
				response.HttpResponseModel = error;

				return response;
			}

			var content = await Json.JsonExtensions.DeserializeAsync<R>(contentStream);
			response.Content = content;

			return response;
		}
	}
}
