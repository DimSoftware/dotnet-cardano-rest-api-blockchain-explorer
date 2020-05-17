using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class CbsEntry
    {
        [JsonPropertyName("cbeEpoch")]
        public ulong CbeEpoch { get; set; }

        [JsonPropertyName("cbeSlot")]
        public ushort CbeSlot { get; set; }

        [JsonPropertyName("cbeBlkHeight")]
        public ulong CbeBlkHeight { get; set; }

        [JsonPropertyName("cbeBlkHash")]
        public string CbeBlkHash { get; set; }

        [JsonPropertyName("cbeTimeIssued")]
        public long CbeTimeIssued { get; set; }

        [JsonPropertyName("cbeTxNum")]
        public ulong CbeTxNum { get; set; }

        [JsonPropertyName("cbeTotalSent")]
        public Coin cbeTotalSent { get; set; }

        [JsonPropertyName("cbeSize")]
        public ulong CbeSize { get; set; }

        [JsonPropertyName("cbeBlockLead")]
        public string CbeBlockLead { get; set; }

        [JsonPropertyName("cbeFees")]
        public Coin CbeFees { get; set; }

    }
}
