using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.FundManager
{
    public class FundManager : IManager
    {

        public List<IFund> MyFund
        {
            get; set;
        }

        public FundManager()
        {
            MyFund = new List<IFund>();

        }

        public void AddFund(StockType stock, double quantity, double price)
        {
            IFund fund = CreateFund(stock, quantity, price);
            MyFund.Add(fund);
        }

        private IFund CreateFund(StockType stock, double quantity, double price)
        {
            IFund myFund;
            switch (stock)
            {
                case StockType.Bond:
                    myFund = new Bond();
                    break;
                case StockType.Equity:
                    myFund = new Equity();
                    break;
                default:
                    return null;
            }
            myFund.Name = GetFundName(stock);
            myFund.Quantity = quantity;
            myFund.Price = price;

            return myFund;

        }

        private string GetFundName(StockType fundType)
        {
            var totalcount = MyFund.Where(x => x.Type == fundType).Count() + 1;
            var newFundName = fundType.ToString("g") + totalcount;

            // generate a new name that doesnt exist already
            while (MyFund.Exists(f => f.Name == newFundName))
            {
                ++totalcount;
                newFundName = fundType.ToString("g") + totalcount;
            }
            return newFundName;

        }
        public List<IFund> GetAllMyFunds()
        {
            //re calculate the weight with latest fund value
            foreach (var fund in MyFund)
                fund.StockWeight = Math.Round((fund.MarketValue / 100) * GetMarketValueOfSpecificFund(fund.Type), 2);

            return MyFund;
        }

        public double GetMarketValueOfSpecificFund(StockType stock)
        {
            return Math.Round(MyFund.Where(f => f.Type == stock).Sum(f => f.MarketValue), 2);
        }

        public double GetMarketValueOfAllFunds()
        {
            return Math.Round(MyFund.Sum(f => f.MarketValue), 2);
        }

        public double GetStockWeightOfSpecificFund(StockType stock)
        {
            GetAllMyFunds();
            return Math.Round(MyFund.Where(f => f.Type == stock).Sum(f => f.StockWeight), 2);
        }

        public double GetStockWeightOfAllFunds()
        {
            GetAllMyFunds();
            return Math.Round(MyFund.Sum(f => f.StockWeight), 2);
        }

        public List<FundSummary> GetFundSummary()
        {
            List<FundSummary> summary = new List<FundSummary>();
            var allFunds = GetAllMyFunds();

            summary.Add(new FundSummary() { Type = StockType.Bond.ToString("g"), TotalNumber = allFunds.Where(f => f.Type == StockType.Bond).Count(), TotalMarketValue = GetMarketValueOfSpecificFund(StockType.Bond), TotalStockWeight = GetStockWeightOfSpecificFund(StockType.Bond) });
            summary.Add(new FundSummary() { Type = StockType.Equity.ToString("g"), TotalNumber = allFunds.Where(f => f.Type == StockType.Equity).Count(), TotalMarketValue = GetMarketValueOfSpecificFund(StockType.Equity), TotalStockWeight = GetStockWeightOfSpecificFund(StockType.Equity) });
            summary.Add(new FundSummary() { Type = "All", TotalNumber = allFunds.Count(), TotalMarketValue = GetMarketValueOfAllFunds(), TotalStockWeight = GetStockWeightOfAllFunds() });

            return summary;

        }
    }
}

