using Cardano.Models.Common;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cardano.Http
{
	public class DeleteRequest
	{
		public static async Task<Response> DeleteAsync(
			string path)
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders
				.Accept
				.Add(new MediaTypeWithQualityHeaderValue(Constants.mediaType));

			var httpResponse = await httpClient.DeleteAsync(HttpHelper.NodeUrlFormat(path));

			var contentStream = await httpResponse.Content.ReadAsStreamAsync();

			var response = new Response();

			var httpResponseModel = await Json.JsonExtensions.DeserializeAsync<HttpResponseModel>(contentStream);

			response.HttpResponseModel = httpResponseModel;

			return response;
		}

		public static async Task<Response<R>> DeleteAsync<R, D>(
			string path,
			D data)
			where R : class
			where D : class
		{
			var httpClient = new HttpClient();

			var dataAsString = Json.JsonExtensions.Serialize(data);
			var httpContent = new StringContent(dataAsString);

			var httpRequestMessage = new HttpRequestMessage();
			httpRequestMessage.Method = HttpMethod.Delete;
			httpRequestMessage
				.Headers
				.Accept
				.Add(new MediaTypeWithQualityHeaderValue(Constants.mediaType));
			httpRequestMessage.Content = httpContent;
			httpRequestMessage.RequestUri = HttpHelper.NodeUrlFormat(path);

			var httpResponse = await httpClient.SendAsync(httpRequestMessage);

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
