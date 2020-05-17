using Cardano.Explorer.Rest.Api.Models.Common;
using Cardano.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class TransactionStatsPage: PolytypeBase<List<object>>
    {
        public override List<object> Data
        {
            set
            {
                this.PageNumber = ulong.Parse(value.ElementAt(0).ToString());
                this.TransactionStatsList = JsonExtensions.Deserialize<List<Tuple<string, ulong>>>(value.ElementAt(1).ToString());
            }
        }

        public ulong PageNumber { get; private set; }

        /// <summary>
        /// List of tuples where: 
        /// The first element is a transaction hash. 
        /// The second element is the size of that transaction in bytes.
        /// </summary>
        public List<Tuple<string, ulong>> TransactionStatsList { get; private set; }
    }
}
