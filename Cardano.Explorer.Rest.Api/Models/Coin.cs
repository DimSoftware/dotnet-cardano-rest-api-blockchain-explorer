using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class Coin
    {
        [JsonPropertyName("getCoin")]
        public string GetCoin { get; set; }
    }
}
