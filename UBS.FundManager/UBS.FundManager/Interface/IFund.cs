using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.FundManager
{
    public interface IFund
    {
        StockType Type { get; }
        string Name { get; set; }
        double Price { get; set; }
        double Quantity { get; set; }
        double MarketValue { get; }
        double TransactionPercent { get; set; }
        double TransactionCost { get; }
        double StockWeight { get; set; }
        double Tolerance { get; }
    }
}
