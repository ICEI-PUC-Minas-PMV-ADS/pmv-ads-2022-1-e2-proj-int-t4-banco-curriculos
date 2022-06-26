using Jobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Jobs.Controllers
{
    
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;


        //  public HomeController(ILogger<HomeController> logger)
        // {
        //      _logger = logger;
        //  }

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var userIdlog = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var candidate = await _context.Candidates.Include(e => e.User).FirstOrDefaultAsync(m => m.UserId == userIdlog);
            return View(candidate);
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
