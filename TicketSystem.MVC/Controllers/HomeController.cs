using Azure.Core.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Text.Json;
using TicketSystem.BL.Helpers;
using TicketSystem.MVC.Models;
using TicketSystem.MVC.Models.AppConfigration;

namespace TicketSystem.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUtilities _utilities;
        private readonly DataConfigration _dataOptions;
        private readonly DataConfigration _dataOptionsSnap;

        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration,
            IOptions<DataConfigration> dataOptions,
            IOptionsSnapshot<DataConfigration> dataOptionsSnap,
            IUtilities utilities
            )
        {
            _logger = logger;
            _configuration = configuration;
            _utilities = utilities;
            _dataOptions = dataOptions.Value;
            _dataOptionsSnap = dataOptionsSnap.Value;
        }

        public IActionResult Index()
        {
            ViewBag.list =new [] { "islam", "amin", "rahaf" };
            ViewBag.Name =_configuration.GetValue<string>("Name");
            ViewBag.Age =_configuration.GetValue<string>("Data:Age");
            ViewBag.Data =JsonSerializer.Serialize(_dataOptions);
            ViewBag.DataSnap =JsonSerializer.Serialize(_dataOptionsSnap);
            ViewBag.DataMonitor = _utilities.GetValueFromConfig();

            return View();
        }

        public IActionResult Privacy()
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
