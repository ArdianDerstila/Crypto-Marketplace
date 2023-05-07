using Newtonsoft.Json;

namespace Crypto_Marketplace.Models
{
    internal class jData
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }
        [JsonProperty("priceChange")]
        public decimal PriceChange { get; set; }
        [JsonProperty("priceChangePercent")]
        public decimal PriceChangePercent { get; set; }

        [JsonProperty("weightedAvgPrice")]
        public decimal WeightedAvgPrice { get; set; }

        [JsonProperty("prevClosePrice")]
        public decimal PrevClosePrice { get; set; }

        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }


        [JsonProperty("lastQty")]
        public decimal LastQty { get; set; }
       
        [JsonProperty("bidPrice")]
        public decimal BidPrice { get; set; }
        
        [JsonProperty("askPrice")]
        public decimal AskPrice { get; set; }

        [JsonProperty("openPrice")]
        public decimal OpenPrice { get; set; }

        [JsonProperty("highPrice")]
        public decimal HighPrice { get; set; }
        
        [JsonProperty("lowPrice")]
        public decimal LowPrice { get; set; }
       
        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        [JsonProperty("closeTime")]
        public decimal CloseTime { get; set; }
        
        [JsonProperty("openTime")]
        public decimal OpenTime { get; set; }
        
        [JsonProperty("firstId")]
        public decimal FirstId { get; set; }
       
        [JsonProperty("lastId")]
        public decimal LastId { get; set; }

        [JsonProperty("count")]
        public decimal Count { get; set; }
       


    }
}