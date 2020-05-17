using Cardano.Explorer.Rest.Api.Models.Common;
using Cardano.Json;
using System.Collections.Generic;
using System.Linq;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class BlockPage: PolytypeBase<List<object>>
    {
        public override List<object> Data 
        { 
            set
            {
                this.PageNumber = ulong.Parse(value.ElementAt(0).ToString());
                this.Blocks = JsonExtensions.Deserialize<List<Block>>(value.ElementAt(1).ToString());
            } 
        }

        public ulong PageNumber { get; private set; }

        public List<Block> Blocks { get; private set; }
    }
}
