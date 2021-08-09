using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaseDeDonnéesLivres.Data;
using BaseDeDonnéesLivres.Models;

namespace BaseDeDonnéesLivres.Controllers
{
    public class LivreDesiresController : Controller
    {
        private readonly BaseDeDonnéesLivresContext _context;

        public LivreDesiresController(BaseDeDonnéesLivresContext context)
        {
            _context = context;
        }

        // GET: LivreDesires
        public async Task<IActionResult> Index()
        {
            return View(await _context.LivreDesire.ToListAsync());
        }

        // GET: LivreDesires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livreDesire = await _context.LivreDesire
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livreDesire == null)
            {
                return NotFound();
            }

            return View(livreDesire);
        }

        // GET: LivreDesires/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LivreDesires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,titre,anneePublication,auteur")] LivreDesire livreDesire)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livreDesire);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livreDesire);
        }

        // GET: LivreDesires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livreDesire = await _context.LivreDesire.FindAsync(id);
            if (livreDesire == null)
            {
                return NotFound();
            }
            return View(livreDesire);
        }

        // POST: LivreDesires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,titre,anneePublication,auteur")] LivreDesire livreDesire)
        {
            if (id != livreDesire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livreDesire);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivreDesireExists(livreDesire.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(livreDesire);
        }

        // GET: LivreDesires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livreDesire = await _context.LivreDesire
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livreDesire == null)
            {
                return NotFound();
            }

            return View(livreDesire);
        }

        // POST: LivreDesires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livreDesire = await _context.LivreDesire.FindAsync(id);
            _context.LivreDesire.Remove(livreDesire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivreDesireExists(int id)
        {
            return _context.LivreDesire.Any(e => e.Id == id);
        }
    }
}
