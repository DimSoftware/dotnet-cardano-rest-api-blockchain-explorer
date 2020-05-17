using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class CtbInputOutput
    {
        [JsonPropertyName("ctaAddress")]
        public string CtaAddress { get; set; }

        [JsonPropertyName("ctaAmount")]
        public Coin CtaAmount { get; set; }

        /// <summary>
        ///  String value validated by the following regex expression: "^[0-9a-f]{64}$" or the value "Genesis Distribution" 
        /// </summary>
        [JsonPropertyName("ctaTxHash")]
        public string CtaTxHash { get; set; }

        [JsonPropertyName("ctaTxIndex")]
        public ulong CtaTxIndex { get; set; }
    }
}
