using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class Transaction
    {
        [JsonPropertyName("ctbId")]
        public string CtbId { get; set; }

        [JsonPropertyName("ctbTimeIssued")]
        public long CtbTimeIssued { get; set; }

        [JsonPropertyName("ctbInputs")]
        public IEnumerable<CtbInputOutput> CtbInputs { get; set; }

        [JsonPropertyName("ctbOutputs")]
        public IEnumerable<CtbInputOutput> CtbOutputs { get; set; }

        [JsonPropertyName("ctbInputSum")]
        public Coin CtbInputSum { get; set; }

        [JsonPropertyName("ctbOutputSum")]
        public Coin CtbOutputSum { get; set; }

        [JsonPropertyName("ctbFees")]
        public Coin CtbFees { get; set; }
    }
}
