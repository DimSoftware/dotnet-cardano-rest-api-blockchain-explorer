using Cardano.Models.Common;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cardano.Http
{
	public class GetRequest
	{
		public static async Task<Response<T>> GetAsync<T>(
			string path)
			where T : class
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders
				.Accept
				.Add(new MediaTypeWithQualityHeaderValue(Constants.mediaType));

			var url = HttpHelper.NodeUrlFormat(path);

			try
			{
				var httpResponse = await httpClient.GetAsync(url);

				if (!httpResponse.IsSuccessStatusCode)
				{
					return Response<T>.GetResponse(
						httpResponse.ReasonPhrase,
						httpResponse.StatusCode);
				}

				var contentStream = await httpResponse.Content?.ReadAsStreamAsync();

				if (contentStream is null)
				{
					return Response<T>.GetResponse(
						"No Content",
						System.Net.HttpStatusCode.NoContent);
				}

				var response = new Response<T>();

				var content = await Json.JsonExtensions.DeserializeAsync<T>(contentStream);
				response.Content = content;

				response.HttpResponseModel = new HttpResponseModel
				{
					Message = nameof(System.Net.HttpStatusCode.OK),
					Code = System.Net.HttpStatusCode.OK
				};

				return response;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
