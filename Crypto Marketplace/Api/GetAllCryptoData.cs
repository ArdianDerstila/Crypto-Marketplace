using Crypto_Marketplace.Models;
using Newtonsoft.Json;

namespace Crypto_Marketplace.Api
{
    public class GetAllCryptoData : IGetData
    {
        public List<Data> GetData(string filter)
        {

            var query = "";
            string binanceAPI = "https://api.binance.com/api/v3/ticker/24hr";

            HttpClient client = new HttpClient();
            List<Data> mylist = new List<Data>();
            HttpResponseMessage response = new HttpResponseMessage();
            if (filter != null)
            {
                query = binanceAPI + "?symbol=" + filter;
                response = client.GetAsync(query).Result;
                string json = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Data>(json);

                mylist.Add(data);
            }
            else
            {
                response = client.GetAsync(binanceAPI).Result;
                string json = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Data>>(json);
                mylist = data;

            }
            return new List<Data>(mylist.Take(10));    
            
        }


    }
}
