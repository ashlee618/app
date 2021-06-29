using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web.Models;
using LeanCloud.LiveQuery;
using LeanCloud.Realtime;
using System;

namespace web.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public async System.Threading.Tasks.Task<IActionResult> Index() {
            LCIMClient tom = new LCIMClient("Tom");
            _logger.LogDebug("jinru");
            try
            {

                await tom.Open();
                _logger.LogDebug("jinru");

                _logger.LogDebug(tom.ToString());
            }
            catch (Exception e)
            {
                _logger.LogDebug("e" + e.Message);
            }
            return View();
        }

        public async System.Threading.Tasks.Task<IActionResult> Privacy() {
            LCIMClient tom = new LCIMClient("Tom");
            _logger.LogDebug("jinru");
            try
            {

                await tom.Open();
                _logger.LogDebug("jinru");

                _logger.LogDebug(tom.ToString());
            }
            catch(Exception e)
            {
                _logger.LogDebug("e"+e.Message);
            }


           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
