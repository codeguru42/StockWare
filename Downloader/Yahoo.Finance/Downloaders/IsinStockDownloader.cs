using System.Collections.Generic;
using System.Threading.Tasks;
using Downloader.Helpers;
using Downloader.Yahoo.Finance.Dtos;
using Downloader.Yahoo.Finance.Dtos.Results;

namespace Downloader.Yahoo.Finance.Downloaders
{
    public class IsinStockDownloader : DownloaderBase
    {
        public IsinStockDownloader()
            : base(@"yahoo.finance.isin")
        {
        }

        public async Task<IsinStock> Download(string isin)
        {
            string url = QueryBuilder.GetUrl(new QueryParameter("symbol", isin));
            var downloadString = await WebClient.DownloadStringTaskAsync(url);
            var rootObject = GetRootObject<IsinStockResults>(downloadString);
            return rootObject.Query.Results.Stock;
        }

        public async Task<List<IsinStock>> Download(string[] isins)
        {
            string url = QueryBuilder.GetUrl(new QueryParameter("symbol", isins));
            var downloadString = await WebClient.DownloadStringTaskAsync(url);
            var rootObject = GetRootObject<IsinStockResultss>(downloadString);
            return rootObject.Query.Results.Stocks;
        }
    }
}