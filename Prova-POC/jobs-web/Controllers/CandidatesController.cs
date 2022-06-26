using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Jobs.Models;

namespace Jobs.Controllers
{
    [Authorize (Roles = "Candidato")]
    public class CandidatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CandidatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Candidates.Include(e => e.User);
            
            return View(await _context.Candidates.ToListAsync());
        }

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var candidate = await _context.Candidates.Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            var userIdlog = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (candidate == null || candidate.UserId != userIdlog)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // GET: Candidates/Resume/5
        public async Task<IActionResult> Resume(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.Include(e => e.User)
                .Include(t => t.Educations)
                .Include(t => t.ProfessionalExperiences)
                .FirstOrDefaultAsync(m => m.Id == id);

            var userIdlog = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (candidate == null || candidate.UserId != userIdlog)
            {
                return NotFound();
            }

            return View(candidate);

        }

        // GET: Candidates/Resume/5
        public async Task<IActionResult> GeneralView(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.Include(e => e.User)
                .Include(t => t.Educations)
                .Include(t => t.ProfessionalExperiences)
                .FirstOrDefaultAsync(m => m.Id == id);

            var userIdlog = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (candidate == null || candidate.UserId != userIdlog)
            {
                return NotFound();
            }

            return View(candidate);

        }


        // GET: Candidates/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

            // POST: Candidates/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Birthdate,Gender,Race,Pwd,Cpf,Linkedin, UserId")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                var userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                candidate.UserId = userIdlogged;

                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction("GeneralView", new { id = candidate.Id });
            }

            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", candidate.UserId);
            return View(candidate);
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.FindAsync(id);

            var userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (candidate == null)
            {
                return NotFound();
            }

            if (candidate.UserId != userIdlogged)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", candidate.UserId);
            return View(candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Birthdate,Gender,Race,Pwd,Cpf,Linkedin, UserId")] Candidate candidate)
        {
            if (id != candidate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                    candidate.UserId = userIdlogged;
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", candidate.UserId);
            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates
                .FirstOrDefaultAsync(m => m.Id == id);

            var userIdlog = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (candidate == null || candidate.UserId != userIdlog)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExists(int id)
        {
            return _context.Candidates.Any(e => e.Id == id);
        }
    }
}
