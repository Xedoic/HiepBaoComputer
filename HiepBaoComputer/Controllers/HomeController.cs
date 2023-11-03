using HiepBaoComputer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HiepBaoComputer.Controllers
{
    public class HomeController : Controller
    {
        private readonly HiepBaoComputerContext _context;

        public HomeController(HiepBaoComputerContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var hiepBaoComputerContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await hiepBaoComputerContext.ToListAsync());
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
