using System.Net;

namespace Cardano.Models.Common
{
	public class Response<T> : Response
	{
		public T Content { get; set; }

		new public static Response<T> GetResponse(
			string message,
			HttpStatusCode code)
			=> new Response<T>
			{
				HttpResponseModel = new HttpResponseModel
				{
					Message = message,
					Code = code
				}
			};
	}

	public class Response
	{
		public HttpResponseModel HttpResponseModel { get; set; }

		public static Response GetResponse(
			string message,
			HttpStatusCode code)
			=> new Response
			{
				HttpResponseModel = new HttpResponseModel
				{
					Message = message,
					Code = code
				}
			};
	}
}
