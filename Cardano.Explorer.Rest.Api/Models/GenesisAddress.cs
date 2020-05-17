using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class GenesisAddress
    {
        [JsonPropertyName("cgaiCardanoAddress")]
        public string CgaiCardanoAddress { get; set; }

        [JsonPropertyName("cgaiGenesisAmount")]
        public Coin CgaiGenesisAmount { get; set; }

        [JsonPropertyName("cgaiIsRedeemed")]
        public bool CgaiIsRedeemed { get; set; }
    }
}
