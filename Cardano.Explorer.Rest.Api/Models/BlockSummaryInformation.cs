using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class BlockSummaryInformation
    {
        [JsonPropertyName("cbsEntry")]
        public CbsEntry CbsEntry { get; set; }

        [JsonPropertyName("cbsPrevHash")]
        public string CbsPrevHash { get; set; }

        [JsonPropertyName("cbsNextHash")]
        public string CbsNextHash { get; set; }

        [JsonPropertyName("cbsMerkleRoot")]
        public string CbsMerkleRoot { get; set; }
    }
}
