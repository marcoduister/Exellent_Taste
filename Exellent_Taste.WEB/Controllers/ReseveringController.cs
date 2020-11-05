using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exellent_Taste.Models;
using Exellent_Taste.BUS.Interface;

namespace Exellent_Taste.WEB.Controllers
{
    public class ReseveringController : Controller
    {
        private readonly IReseveringenService _ReseveringenService;
        private readonly IBlackListService _BlackListService;
        private readonly IBestellingenService _BestellingenService;


        public ReseveringController(IReseveringenService ReseveringenService, IBlackListService blackListService, IBestellingenService BestellingenService)
        {
            _ReseveringenService = ReseveringenService;
            _BlackListService = blackListService;
            _BestellingenService = BestellingenService;
        }

        // GET: Resevering
        public async Task<IActionResult> Index()
        {
            var Model = await _ReseveringenService.GetAll();
            return View(Model);
        }

        // GET: Resevering/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var resevering = await _ReseveringenService.GetById(id);
            if (resevering == null)
            {
                return NotFound();
            }

            return View(resevering);
        }

        // GET: Resevering/Create
        public IActionResult Create()
        {
            Reseveringen resevering = new Reseveringen()
            {
                Adress = new Adress()
            };
            return View(resevering);
        }

        // POST: Resevering/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Reseveringen Model)
        {
            if (ModelState.IsValid)
            {
                //var Blacklist = await _BlackListService.GetByEmail(Model.Email);
                if (true)
                {
                    await _ReseveringenService.Create(Model);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //ModelState.AddModelError("gekomenError", "Deze klant is een keer niet gekomen zonder aftezeggen");
                }
            }
            return View(Model);
        }

        // GET: Resevering/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var resevering = await _ReseveringenService.GetById(id);
            if (resevering == null)
            {
                return NotFound();
            }
            return View(resevering);
        }

        // POST: Resevering/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Reseveringen Model)
        {
            if (id != Model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var resevering = await _ReseveringenService.GetById(id);
                if (resevering != null)
                {
                    await _ReseveringenService.Edit(Model);
                }
                else
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        // GET: Resevering/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var resevering = await _ReseveringenService.GetById(id);
            if (resevering == null)
            {
                return NotFound();
            }
            return View(resevering);
        }

        // POST: DeleteConfirmed
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
 
                var resevering = await _ReseveringenService.GetById(id);
                if (resevering != null)
                {
                    await _ReseveringenService.Delete(resevering);
                }
                else
                {
                    return NotFound();
                }
            return RedirectToAction(nameof(Index));
        }
        // GET: Bestelling/Delete/5
        public async Task<IActionResult> Bestelling(int _id, int _Resevering, int _Tafel)
        {
            if (_id == 0)
            {
                var model = new Bestellingen()
                {
                    Tafel = _Tafel,
                };
                var bestelling = await _BestellingenService.Create(model);
                var resevering = await _ReseveringenService.GetById(_Resevering);
                resevering.Bestelling_id = bestelling.ID;
                await _ReseveringenService.Edit(resevering);

                return RedirectToAction("Details", "Bestellings", new { id = bestelling.ID });
            }
            else
            {
                return RedirectToAction("Details", "Bestellings", new { id = _id });
            }

        }

        private bool ReseveringenExists(int id)
        {
            if (_ReseveringenService.GetById(id) != null)
            {   return true;    }
            else { return false; }
        }
    }
}
