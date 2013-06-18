﻿using Newtonsoft.Json;

namespace Downloader.Dtos
{
    [JsonObject(Id = "Quote")]
    public class EodPoint
    {
        public string date { get; set; }
        public string Date { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string Volume { get; set; }
        public string Adj_Close { get; set; }
    }
}