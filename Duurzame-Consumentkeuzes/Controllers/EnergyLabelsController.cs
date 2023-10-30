using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Models;

namespace Duurzame_Consumentkeuzes.Controllers
{
    public class EnergyLabelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnergyLabelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EnergyLabels
        public async Task<IActionResult> Index()
        {
              return _context.EnergyLabels != null ? 
                          View(await _context.EnergyLabels.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.EnergyLabels'  is null.");
        }

        // GET: EnergyLabels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EnergyLabels == null)
            {
                return NotFound();
            }

            var energyLabel = await _context.EnergyLabels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (energyLabel == null)
            {
                return NotFound();
            }

            return View(energyLabel);
        }

        // GET: EnergyLabels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EnergyLabels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EfficiencyClass")] EnergyLabel energyLabel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(energyLabel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(energyLabel);
        }

        // GET: EnergyLabels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EnergyLabels == null)
            {
                return NotFound();
            }

            var energyLabel = await _context.EnergyLabels.FindAsync(id);
            if (energyLabel == null)
            {
                return NotFound();
            }
            return View(energyLabel);
        }

        // POST: EnergyLabels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EfficiencyClass")] EnergyLabel energyLabel)
        {
            if (id != energyLabel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(energyLabel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnergyLabelExists(energyLabel.Id))
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
            return View(energyLabel);
        }

        // GET: EnergyLabels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EnergyLabels == null)
            {
                return NotFound();
            }

            var energyLabel = await _context.EnergyLabels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (energyLabel == null)
            {
                return NotFound();
            }

            return View(energyLabel);
        }

        // POST: EnergyLabels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EnergyLabels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.EnergyLabels'  is null.");
            }
            var energyLabel = await _context.EnergyLabels.FindAsync(id);
            if (energyLabel != null)
            {
                _context.EnergyLabels.Remove(energyLabel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnergyLabelExists(int id)
        {
          return (_context.EnergyLabels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
