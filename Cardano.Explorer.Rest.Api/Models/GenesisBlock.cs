using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class GenesisBlock
    {
        [JsonPropertyName("cgsNumTotal")]
        public ulong CgsNumTotal { get; set; }

        [JsonPropertyName("cgsNumRedeemed")]
        public ulong CgsNumRedeemed { get; set; }

        [JsonPropertyName("cgsNumNotRedeemed")]
        public ulong CgsNumNotRedeemed { get; set; }

        [JsonPropertyName("cgsRedeemedAmountTotal")]
        public Coin CgsRedeemedAmountTotal { get; set; }

        [JsonPropertyName("cgsNonRedeemedAmountTotal")]
        public Coin CgsNonRedeemedAmountTotal { get; set; }
    }
}
