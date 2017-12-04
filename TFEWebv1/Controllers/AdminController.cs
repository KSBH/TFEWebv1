using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFEWebv1.Data;
using System.Net;
using System.IO;
using TFEWebv1.Models.AdminViewModels;
using TFEWebv1.Models;

namespace TFEWebv1.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
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
        public async Task Register(RegisterArticlesViewModel vm)
        {
            WebRequest request = WebRequest.Create("http://localhost:61116/admin/newarticles");
            WebResponse response = await request.GetResponseAsync();
            Stream data = response.GetResponseStream();
            string html = String.Empty;
            using (StreamReader sr = new StreamReader(data))
            {
                html = sr.ReadToEnd();
                int startPos = html.LastIndexOf("<ul id='dropitdown'></ul>") + "<ul id='dropitdown'></ul>".Length + 1;
                int length = html.IndexOf("<input type='submit' />") - startPos;
                string sub = html.Substring(startPos, length);
                
            }
            var x = vm.Content;
            var article = new Articles
            {
                Name = vm.Name,
                Description = vm.Description,
                Content = vm.Content
            };
            _context.Articles.Add(article);
            _context.SaveChanges();
        }
    }
}