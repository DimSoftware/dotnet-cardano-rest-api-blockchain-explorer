using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class TransactionSummaryInformation
    {
        /// <summary>
        ///  String value validated by the following regex expression: "^[0-9a-f]{64}$" or the value "Genesis Distribution" 
        /// </summary>
        [JsonPropertyName("ctsId")]
        public string CtsId { get; set; }

        [JsonPropertyName("ctsTxTimeIssued")]
        public long CtsTxTimeIssued { get; set; }

        [JsonPropertyName("ctsBlockTimeIssued")]
        public long ctsBlockTimeIssued { get; set; }

        [JsonPropertyName("ctsBlockHeight")]
        public ulong CtsBlockHeight { get; set; }

        [JsonPropertyName("ctsBlockEpoch")]
        public ulong CtsBlockEpoch { get; set; }

        [JsonPropertyName("ctsBlockSlot")]
        public ushort CtsBlockSlot { get; set; }

        [JsonPropertyName("ctsBlockHash")]
        public string CtsBlockHash { get; set; }
            
        [JsonPropertyName("ctsRelayedBy")]
        public string CtsRelayedBy { get; set; }

        [JsonPropertyName("ctsTotalInput")]
        public Coin CtsTotalInput { get; set; }

        [JsonPropertyName("ctsTotalOutput")]
        public Coin CtsTotalOutput { get; set; }

        [JsonPropertyName("ctsFees")]
        public Coin CtsFees { get; set; }

        [JsonPropertyName("ctsInputs")]
        public IEnumerable<CtbInputOutput> CtsInputs { get; set; }

        [JsonPropertyName("ctsOutputs")]
        public IEnumerable<CtbInputOutput> CtsOutputs { get; set; }
    }
}
