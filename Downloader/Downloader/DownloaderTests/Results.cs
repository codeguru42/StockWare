﻿using Newtonsoft.Json;

namespace DownloaderTests
{
    [JsonObject(Id = "Result")]
    public class QuoteResults
    {
        public Quote Quote { get; set; }
    }
}