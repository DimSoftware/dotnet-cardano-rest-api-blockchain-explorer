using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class CaChainTip
    {
        [JsonPropertyName("ctBlockNo")]
        public ulong CtBlockNo { get; set; }

        [JsonPropertyName("ctSlotNo")]
        public ulong CtSlotNo { get; set; }

        [JsonPropertyName("ctBlockHash")]
        public string CtBlockHash { get; set; }
    }
}
