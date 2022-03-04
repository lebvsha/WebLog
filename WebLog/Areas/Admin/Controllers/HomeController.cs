using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLog.Domain.Repositories;

namespace WebLog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager _datamanager;
        public HomeController(DataManager dm)
        {
            _datamanager = dm;
        }
        public IActionResult Index()
        {
            return View(_datamanager.ServiceItems.GetServiceItem());
        }
    }
}
