using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.FundManager
{
    public abstract class Fund : IFund
    {

        public double MarketValue
        {
            get { return Math.Round(Price * Quantity, 2); }
        }

        public string Name
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public double Quantity
        {
            get; set;
        }

        public double StockWeight
        {
            get; set;
        }

        public virtual double Tolerance
        {
            get;
        }

        public double TransactionCost
        {
            get { return Math.Round(MarketValue * TransactionPercent, 2); }
        }

        public virtual double TransactionPercent
        {
            get; set;
        }

        public virtual StockType Type
        {
            get;
        }
    }
}
