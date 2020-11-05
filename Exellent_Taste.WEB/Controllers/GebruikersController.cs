using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exellent_Taste.Models;
using Exellent_Taste.BUS.Interface;

namespace Exellent_Taste.WEB.Controllers
{
    public class GebruikersController : Controller
    {
        private readonly IGebruikersService _GebruikersService;


        public GebruikersController(IGebruikersService gebruikersService)
        {
            _GebruikersService = gebruikersService;
        }

        // GET: Gebruikers
        public async Task<IActionResult> Index()
        {
            var Model = await _GebruikersService.GetAll();
            return View(Model);
        }

        // GET: Gebruikers/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var gebruikers =  await _GebruikersService.GetById(id);
            if (gebruikers == null)
            {
                return NotFound();
            }

            return View(gebruikers);
        }

        // GET: Gebruikers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gebruikers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Voornaam,Achternaam,Email,Wachtwoord,SID,Created_Gebruiker_Id,Updated_Gebruiker_Id,Created_Datum,Updated_Datum")] Gebruikers Model)
        {
            if (ModelState.IsValid)
            {
                await _GebruikersService.Create(Model);
                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        // GET: Gebruikers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
           
            var gebruikers = await _GebruikersService.GetById(id);
            if (gebruikers == null)
            {
                return NotFound();
            }
            return View(gebruikers);
        }

        // POST: Gebruikers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Gebruikers Model)
        {
            if (id != Model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var gebruikers = await _GebruikersService.GetById(id);
                if (gebruikers != null)
                {
                    await _GebruikersService.Edit(Model);
                }
                else
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        // GET: Gebruikers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var gebruikers = await _GebruikersService.GetById(id);
            if (gebruikers == null)
            {
                return NotFound();
            }
            return View(gebruikers);
        }

        // POST: Gebruikers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                var gebruikers = await _GebruikersService.GetById(id);
                if (gebruikers != null)
                {
                    await _GebruikersService.Delete(gebruikers);
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
