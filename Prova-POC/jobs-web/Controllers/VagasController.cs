using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jobs.Models;
using jobs_web.Models;
using System.Security.Claims;

namespace jobs_web.Controllers
{
    public class VagasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VagasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vagas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vagas.Include(v => v.Empresa);
            return View(await applicationDbContext.ToListAsync());
        }

        //Buscar vagas
        public async Task<IActionResult> Search(string searchString)
        {
            var vacancies = from v in _context.Vagas
                         select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                vacancies = vacancies.Where(s => s.Cargo!.Contains(searchString));
            }

            return View(await vacancies.ToListAsync());
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas
                .Include(v => v.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> DetailsVacancy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas
                .Include(v => v.Empresa).Include(u => u.Empresa.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // GET: Vagas/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "cnpj");
            return View();
        }

        // POST: Vagas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cargo,descricao,quantidade_vagas,status,RegistrationDate,ClosingDate,EmpresaId")] Vagas vagas)
        {
            if (ModelState.IsValid)

            {
                DateTime data = DateTime.Now;
                vagas.RegistrationDate = data;

                vagas.status = true;

                var userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var empresa = await _context.Empresa.FirstOrDefaultAsync(m => m.UserId == userIdlogged);

                vagas.EmpresaId = empresa.Id;

                _context.Add(vagas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "cnpj", vagas.EmpresaId);
            return View(vagas);
        }

        // GET: Vagas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas.FindAsync(id);
            if (vagas == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "cnpj", vagas.EmpresaId);
            return View(vagas);
        }

        // POST: Vagas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cargo,descricao,quantidade_vagas,status,RegistrationDate,ClosingDate,EmpresaId")] Vagas vagas)
        {
            if (id != vagas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userIdlogged = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    var empresa = await _context.Empresa.FirstOrDefaultAsync(m => m.UserId == userIdlogged);

                    vagas.EmpresaId = empresa.Id;
                    _context.Update(vagas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagasExists(vagas.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "cnpj", vagas.EmpresaId);
            return View(vagas);
        }

        // GET: Vagas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.Vagas
                .Include(v => v.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // POST: Vagas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vagas = await _context.Vagas.FindAsync(id);
            _context.Vagas.Remove(vagas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VagasExists(int id)
        {
            return _context.Vagas.Any(e => e.Id == id);
        }
    }
}
