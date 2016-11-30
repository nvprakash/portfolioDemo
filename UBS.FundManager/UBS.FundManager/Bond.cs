using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.FundManager
{
    public class Bond : Fund
    {
        public override StockType Type
        {
            get
            {
                return StockType.Bond;
            }
        }
        public override double TransactionPercent
        {
            get
            {
                return 0.02;
            }
        }

        public override double Tolerance { get { return 100000; } }

    }
}
