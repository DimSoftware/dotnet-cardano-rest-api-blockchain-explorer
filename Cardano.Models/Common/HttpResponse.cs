using System.Net;
using System.Text.Json.Serialization;

namespace Cardano.Models.Common
{
	public class HttpResponseModel
	{
		[JsonPropertyName("message")]
		public string Message { get; set; }

		[JsonPropertyName("code")]
		public HttpStatusCode Code { get; set; }
	}
}
