using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TFEWebv1.Data;
using TFEWebv1.Models;

namespace TFEWebv1.Controllers
{
    public class ScriptElementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScriptElementsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ScriptElements
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScriptElements.ToListAsync());
        }

        // GET: ScriptElements/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scriptElements = await _context.ScriptElements
                .SingleOrDefaultAsync(m => m.Id == id);
            if (scriptElements == null)
            {
                return NotFound();
            }

            return View(scriptElements);
        }

        // GET: ScriptElements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScriptElements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Content")] ScriptElements scriptElements)
        {
            if (ModelState.IsValid)
            {
                scriptElements.Id = Guid.NewGuid();
                _context.Add(scriptElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(scriptElements);
        }

        // GET: ScriptElements/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scriptElements = await _context.ScriptElements.SingleOrDefaultAsync(m => m.Id == id);
            if (scriptElements == null)
            {
                return NotFound();
            }
            return View(scriptElements);
        }

        // POST: ScriptElements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Content")] ScriptElements scriptElements)
        {
            if (id != scriptElements.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scriptElements);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScriptElementsExists(scriptElements.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(scriptElements);
        }

        // GET: ScriptElements/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scriptElements = await _context.ScriptElements
                .SingleOrDefaultAsync(m => m.Id == id);
            if (scriptElements == null)
            {
                return NotFound();
            }

            return View(scriptElements);
        }

        // POST: ScriptElements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var scriptElements = await _context.ScriptElements.SingleOrDefaultAsync(m => m.Id == id);
            _context.ScriptElements.Remove(scriptElements);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ScriptElementsExists(Guid id)
        {
            return _context.ScriptElements.Any(e => e.Id == id);
        }
        public async Task<IActionResult> ScriptMaker()
        {
            return View(await _context.ScriptElements.ToListAsync());
        }
    }
}
