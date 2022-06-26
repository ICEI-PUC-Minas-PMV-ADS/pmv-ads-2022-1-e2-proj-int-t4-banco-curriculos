using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jobs.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Jobs.Controllers
{
    [Authorize(Roles = "Candidato")]
    public class ProfessionalExperiencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfessionalExperiencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProfessionalExperiences
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProfessionalExperiences.Include(p => p.Candidate);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProfessionalExperiences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalExperience = await _context.ProfessionalExperiences
                .Include(p => p.Candidate)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professionalExperience == null)
            {
                return NotFound();
            }

            return View(professionalExperience);
        }

        // GET: ProfessionalExperiences/Create
        public IActionResult Create()
        {
            ViewData["CandidateId"] = new SelectList(_context.Candidates, "Id", "Name");
            return View();
        }

        // POST: ProfessionalExperiences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Occupation,TypeOfJob,CompanyName,Locality,StartDate,EndDate,Activity,Description,CandidateId")] ProfessionalExperience professionalExperience)
        {
            if (ModelState.IsValid)
            {
                int userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var candidate = await _context.Candidates.FirstOrDefaultAsync(m => m.UserId == userIdlogged);

                professionalExperience.CandidateId = candidate.Id;

                _context.Add(professionalExperience);
                await _context.SaveChangesAsync();
                return RedirectToAction("GeneralView", "Candidates", new { id = candidate.Id });
            }
            ViewData["CandidateId"] = new SelectList(_context.Candidates, "Id", "Name", professionalExperience.CandidateId);
            return View(professionalExperience);
        }

        // GET: ProfessionalExperiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalExperience = await _context.ProfessionalExperiences
    .Include(p => p.Candidate)
    .FirstOrDefaultAsync(m => m.Id == id);
            if (professionalExperience == null)
            {
                return NotFound();
            }
            ViewData["CandidateId"] = new SelectList(_context.Candidates, "Id", "Name", professionalExperience.CandidateId);
            return View(professionalExperience);
        }

        // POST: ProfessionalExperiences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Occupation,TypeOfJob,CompanyName,Locality,StartDate,EndDate,Activity,Description,CandidateId")] ProfessionalExperience professionalExperience)
        {
            if (id != professionalExperience.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    int userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    var candidate = await _context.Candidates.FirstOrDefaultAsync(m => m.UserId == userIdlogged);

                    professionalExperience.CandidateId = candidate.Id;
                    _context.Update(professionalExperience);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessionalExperienceExists(professionalExperience.Id))
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
            ViewData["CandidateId"] = new SelectList(_context.Candidates, "Id", "Name", professionalExperience.CandidateId);
           return View(professionalExperience);
        }

        // GET: ProfessionalExperiences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalExperience = await _context.ProfessionalExperiences
                .Include(p => p.Candidate)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professionalExperience == null)
            {
                return NotFound();
            }

            return View(professionalExperience);
        }

        // POST: ProfessionalExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professionalExperience = await _context.ProfessionalExperiences.FindAsync(id);
            _context.ProfessionalExperiences.Remove(professionalExperience);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessionalExperienceExists(int id)
        {
            return _context.ProfessionalExperiences.Any(e => e.Id == id);
        }
    }
}
