using Crypto_Marketplace.Api;
using Crypto_Marketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Crypto_Marketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetData _IGetData;
       

        public HomeController(ILogger<HomeController> logger, IGetData iGetData)
        {
            _logger = logger;
            _IGetData = iGetData;
        }


        public ActionResult Index(string filter )
        {
            List<Data> mylist = new List<Data>();
            mylist=_IGetData.GetData(filter);
            
            return View(mylist);
        }


       // List<jData> list = new List<jData>();
        public async Task<ActionResult> _tableData()
        {

           
            string binanceAPI = "https://api.binance.com/api/v3/ticker/24hr";

            HttpClient client = new HttpClient();
            List<Data> mylist = new List<Data>();
            HttpResponseMessage response = new HttpResponseMessage();

            response = client.GetAsync(binanceAPI).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            var data = JsonConvert.DeserializeObject<List<Data>>(json);
            mylist = data;


            return View(mylist.Take(10));
        }


        
       
        public async Task<JsonResult> ChartD()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.binance.com/api/v3/ticker/24hr");
                var content = await response.Content.ReadAsStringAsync();
                var DeserializeObjectD = JsonConvert.DeserializeObject<List<jData>>(content);
                var firstElement = DeserializeObjectD.First();
                return Json(firstElement.PriceChangePercent);

            }
        }

        //test
        public async Task<JsonResult> ChartD1()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.binance.com/api/v3/ticker/24hr");
                var content = await response.Content.ReadAsStringAsync();
                var DeserializeObjectD = JsonConvert.DeserializeObject<List<jData>>(content);
                var firstElement = DeserializeObjectD.First();
                return Json(firstElement.PriceChangePercent);

            }
        }


        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}