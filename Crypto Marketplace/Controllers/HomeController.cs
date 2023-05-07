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
           
            ViewBag.data = _IGetData.GetData(filter);
            return View();
        }

       

        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        
        public IActionResult Services()
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