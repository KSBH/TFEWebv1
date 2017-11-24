using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TFEWebv1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> NewTutorials()
        {
            //await ;
            return View();
        }
        public async Task<IActionResult> NewArticles()
        {
            //await ;
            return View();
        }
    }
}