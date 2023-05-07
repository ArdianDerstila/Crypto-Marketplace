namespace Crypto_Marketplace.Models
{
    public class Data
    {

       
        public string? symbol { get; set; }
        public decimal? priceChange { get; set; }    
        public decimal? priceChangePercent { get; set; }
        public decimal? prevClosePrice { get; set; }
        public decimal? lastprice { get; set; }
        public decimal? lastQty { get; set; }
        public decimal? bidPrice { get; set; }
        public decimal? bidQty { get; set; }
        public decimal? askPrice { get; set; }
        public decimal? askQty { get; set; }
        public decimal openPrice { get; set; }
        public decimal? highPrice { get; set; }
        public decimal? lowPrice { get; set; }
        public decimal? volume { get; set; }
        public decimal? quoteVolume { get; set; }
        public decimal? openTime { get; set; }
        public decimal? closeTime { get; set; }
        public decimal? firstId { get; set; }
        public decimal? lastId { get; set; }
        public int?  count { get; set; }
    }

    
}
