using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockIndex { get; set; }
        public string StockDescription { get; set; }
        public double StockValue { get; set; }

        public int MarketId { get; set; }
        public virtual Market Market { get; set; }
    }
}
