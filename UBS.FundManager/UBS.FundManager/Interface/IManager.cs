using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.FundManager
{
    interface IManager
    {
        List<IFund> MyFund { get; set; }
        void AddFund(StockType stock, double quantity, double price);
        List<IFund> GetAllMyFunds();
        double GetMarketValueOfSpecificFund(StockType stock);
        double GetMarketValueOfAllFunds();
        double GetStockWeightOfSpecificFund(StockType stock);
        double GetStockWeightOfAllFunds();
        List<FundSummary> GetFundSummary();
    }
}
