using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class AddressBalance
    {
		[JsonPropertyName("address")]
		public string Address { get; set; }

		/// <summary>
		///  String value validated by the following regex expression: "^[0-9a-f]{64}$" or the value "Genesis Distribution" 
		/// </summary>
		[JsonPropertyName("txid")]
		public string TxId { get; set; }

		[JsonPropertyName("index")]
		public ushort Index { get; set; }

		[JsonPropertyName("coin")]
		public ulong Coin { get; set; }
	}
}
