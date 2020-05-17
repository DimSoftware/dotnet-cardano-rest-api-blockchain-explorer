using Cardano.Models.Common;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cardano.Http
{
	public class PutRequest
	{
		public static async Task<Response<R>> PutAsync<R, D>(
			string path,
			D data)
			where R : class
			where D : class
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders
				.Accept
				.Add(new MediaTypeWithQualityHeaderValue(Constants.mediaType));

			var dataAsString = Json.JsonExtensions.Serialize(data);
			var httpContent = new StringContent(dataAsString);
			var httpResponse = await httpClient.PutAsync(HttpHelper.NodeUrlFormat(path), httpContent);

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

		public static async Task<Response> PutAsync<D>(
			string path,
			D data)
			where D : class
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders
				.Accept
				.Add(new MediaTypeWithQualityHeaderValue(Constants.mediaType));

			var dataAsString = Json.JsonExtensions.Serialize(data);
			var httpContent = new StringContent(dataAsString);
			var httpResponse = await httpClient.PutAsync(HttpHelper.NodeUrlFormat(path), httpContent);

			var contentStream = await httpResponse.Content.ReadAsStreamAsync();

			var response = new Response();

			var httpResponseModel = await Json.JsonExtensions.DeserializeAsync<HttpResponseModel>(contentStream);

			response.HttpResponseModel = httpResponseModel;

			return response;
		}
	}
}
