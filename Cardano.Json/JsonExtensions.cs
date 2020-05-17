using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cardano.Json
{
	public static class JsonExtensions
	{
		public static async Task<T> DeserializeAsync<T>(Stream stream)
			where T : class
			=> await JsonSerializer.DeserializeAsync<T>(stream);

		public static T Deserialize<T>(string content)
			where T : class
			=> JsonSerializer.Deserialize<T>(content);

		public static string Serialize<T>(T data)
			where T : class
			=> JsonSerializer.Serialize(data);
	}
}
