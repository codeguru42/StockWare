using System.Collections.Generic;
using Newtonsoft.Json;

namespace Downloader.Yahoo.Finance.Dtos.Results
{
    public class IsinStockResultss
    {
        [JsonProperty(PropertyName = "stock")]
        public List<ISINMatch> Stocks { get; set; }
    }
}