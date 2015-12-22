using System.IO;
using System.Net;

namespace YahooStockDownloader
{
    public static class GetIndices
    {
        public static string GetDow30()
        {
            //Access Barchart.com to get Dow 30 components
            HttpWebRequest request = (HttpWebRequest)WebRequest
                .Create("http://www.barchart.com/stocks/industrials.php?view=main");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Read source of request to WebPageInfo string
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string webPageInfo = stream.ReadToEnd();

            //Trim returned text to get tickers
            int index = webPageInfo.IndexOf("\"symbols\"");
            webPageInfo = webPageInfo.Substring(index + 9);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(index + 2);

            index = webPageInfo.IndexOf(",,");
            webPageInfo = webPageInfo.Substring(0, index);

            webPageInfo = webPageInfo.Replace(",", ", ");

            return webPageInfo;
        }

        public static string GetSP100()
        {
            //Access Barchart.com to get Dow 30 components
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.barchart.com/stocks/sp100.php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Read source of request to WebPageInfo string
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string webPageInfo = stream.ReadToEnd();

            //Trim returned text to get tickers
            int index = webPageInfo.IndexOf("\"symbols\"");
            webPageInfo = webPageInfo.Substring(index + 9);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(index + 2);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(0, index);

            webPageInfo = webPageInfo.Replace(",", ", ");
            webPageInfo = webPageInfo.Replace(".", "-");

            return webPageInfo;
        }

        public static string Nasdaq100()
        {
            //Access Barchart.com to get Dow 30 components
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.barchart.com/stocks/nasdaq100.php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Read source of request to WebPageInfo string
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string webPageInfo = stream.ReadToEnd();

            //Trim returned text to get tickers
            int index = webPageInfo.IndexOf("\"symbols\"");
            webPageInfo = webPageInfo.Substring(index + 9);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(index + 2);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(0, index);

            webPageInfo = webPageInfo.Replace(",", ", ");

            return webPageInfo;
        }
    }
}
