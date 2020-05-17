using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class TransactionInformation
    {
        /// <summary>
        ///  String value validated by the following regex expression: "^[0-9a-f]{64}$" or the value "Genesis Distribution" 
        /// </summary>
        [JsonPropertyName("cteId")]
        public string CteId { get; set; }

        [JsonPropertyName("cteTimeIssued")]
        public long CteTimeIssued { get; set; }

        [JsonPropertyName("cteAmount")]
        public Coin CteAmount { get; set; }
    }
}
