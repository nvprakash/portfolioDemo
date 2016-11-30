using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UBS.FundManager.Test
{
    [TestClass]
    public class UnitTest1
    {
        FundManager manager;


        [TestInitialize]
        public void setup()
        {
            manager = new FundManager();
        }

        [TestMethod]
        public void should_display_correct_count_when_funds_are_added()
        {
            //Arrange

            //Act
            manager.AddFund(StockType.Equity, 1, 50);

            //Assert
            Assert.AreEqual<int>(1, manager.GetAllMyFunds().Count);
        }

        [TestMethod]
        public void should_display_correct_stock_name()
        {
            //arrange
            var stockName = "Bond2";
            //act
            manager.AddFund(StockType.Equity, 1, 50);
            manager.AddFund(StockType.Bond, 1, 50);
            manager.AddFund(StockType.Bond, 1, 50);
            manager.AddFund(StockType.Equity, 1, 50);
            //assert
            Assert.AreEqual<string>(stockName, manager.MyFund[2].Name);
        }

        [TestMethod]
        public void should_calculate_market_value_correctly_for_equity()
        {
            //arrange
            var expectedMarketValue = 20.4;

            //act
            manager.AddFund(StockType.Equity, 4, 5.1);

            //Assert
            Assert.AreEqual<double>(expectedMarketValue, manager.GetMarketValueOfSpecificFund(StockType.Equity));
        }

        [TestMethod]
        public void should_calculate_market_value_correctly_for_AllFunds()
        {
            //arrange
            double expectedMarketValue = 17.3;

            //act
            manager.AddFund(StockType.Equity, 1, 5.1);
            manager.AddFund(StockType.Bond, 2, 6.1);

            //Assert
            Assert.AreEqual<double>(expectedMarketValue, manager.GetMarketValueOfAllFunds());
        }



        [TestMethod]
        public void should_calculate_stock_weight_correctly_for_AllFunds()
        {
            //arrange
            double expectedMarketValue = 1.75;

            //act
            manager.AddFund(StockType.Equity, 1, 5.1);
            manager.AddFund(StockType.Bond, 2, 6.1);

            //Assert
            Assert.AreEqual<double>(expectedMarketValue, manager.GetStockWeightOfAllFunds());
        }


    }
}
