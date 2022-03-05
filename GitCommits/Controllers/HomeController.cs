using GitCommits.FakeDb;
using GitCommits.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new()
            {
                DataList = AppDbContext.DataOfLists
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(DataOfList data)
        {
            DAL.AddDataService.AddData(data.Title, data.Cotnent);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int deleteId)
        {
            DAL.RemoveDataServices.RemoveData(deleteId);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int updateId)
        {
            return View(new DataOfList());
        }

        [HttpPost]
        public IActionResult Update(DataOfList model)
        {
            DAL.UpdateDataService.UpdateData(model);
            return RedirectToAction("Index");
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
