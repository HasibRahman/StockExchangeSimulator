using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace StockExchangeSimulatorApp
{
    /// <summary>
    /// Summary description for StockExchangeService
    /// </summary>
    [WebService(Namespace = "http://hasibrahman.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class StockExchangeService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Stock> GetStockPrices()
        {
            Random r = new Random();
            List<Stock> stockList = new List<Stock>
            {
                new Stock {StockCode = "AAPL",StockPrice =r.Next(1,1000) },
                new Stock {StockCode = "IYW",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "AUY",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "QQQ",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "MSFT",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "XLK",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "ACN",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "TGT",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "INTC",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "VGT",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "GOOG",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "AHX",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "KO",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "BRKA",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "TXN",StockPrice = r.Next(1,1000)},
                new Stock {StockCode = "AZS",StockPrice = r.Next(1,1000)},
            };

            return stockList;
        }
    }
}
