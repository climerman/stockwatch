using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Market
    {
        public int MarketId { get; set; }
        public string MarketIndex { get; set; }
        public string MarketDescription { get; set; }

        public virtual List<Market> Markets { get; set; }

    }
}
