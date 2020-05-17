using System.Collections.Generic;
using System.Text.Json.Serialization;
using Cardano.Core.Nomenclatures;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class Address
    {
        private CaTypeEnum _caType;

        [JsonPropertyName("caAddress")]
        public string CaAddress { get; set; }

        [JsonPropertyName("caType")]
        public string CaType 
        { 
            get 
            { 
                return _caType.GetValue(); 
            } 
            set 
            {
                if (CaTypeEnum.CPubKeyAddress.GetValue().Equals(value))
                {
                    _caType = CaTypeEnum.CPubKeyAddress;
                }
                else if (CaTypeEnum.CRedeemAddress.GetValue().Equals(value))
                {
                    _caType = CaTypeEnum.CRedeemAddress;
                }
            } 
        }

        [JsonPropertyName("caChainTip")]
        public CaChainTip CaChainTip { get; set; }

        [JsonPropertyName("caTxNum")]
        public ulong CaTxNum { get; set; }

        [JsonPropertyName("caBalance")]
        public Coin CaBalance { get; set; }

        [JsonPropertyName("caTotalInput")]
        public Coin CaTotalInput { get; set; }

        [JsonPropertyName("caTotalOutput")]
        public Coin CaTotalOutput { get; set; }

        [JsonPropertyName("caTotalFee")]
        public Coin CaTotalFee { get; set; }

        [JsonPropertyName("caTxList")]
        public IEnumerable<Transaction> CaTxList { get; set; }
    }
}
