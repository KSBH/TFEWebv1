using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFEWebv1.Data;
using System.Net;
using System.IO;

namespace TFEWebv1.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
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
        public async void Register()
        {
            WebRequest request = WebRequest.Create("http://localhost:61116/admin/newarticles");
            WebResponse response = await request.GetResponseAsync();
            Stream data = response.GetResponseStream();
            string html = String.Empty;
            using (StreamReader sr = new StreamReader(data))
            {
                html = sr.ReadToEnd();
            }
            
        }
    }
}