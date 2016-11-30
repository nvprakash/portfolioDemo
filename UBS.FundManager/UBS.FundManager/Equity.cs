using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.FundManager
{
    public class Equity : Fund
    {
        public override double TransactionPercent
        {
            get
            {
                return 0.005;
            }
        }


        public override double Tolerance { get { return 200000; } }
    }
}
