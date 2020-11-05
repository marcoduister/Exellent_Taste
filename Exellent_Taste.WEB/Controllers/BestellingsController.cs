using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exellent_Taste.Models;
using Exellent_Taste.BUS.Interface;
using Nancy.Json;
using System.IO;
using System.Text;
using System.Data;
using Microsoft.AspNet.Mvc.ViewFeatures;
using Rotativa.AspNetCore;

namespace Exellent_Taste.WEB.Controllers
{
    public class BestellingsController : Controller
    {
        private readonly IBestellingenService _IBestellingenService;
        private readonly IBestellings_LijstService _Ibestellings_LijstService;
        private readonly IMenukaartService _ImenukaartService;
        private readonly IMenuSoortService _IMenuSoortService;

        public BestellingsController(IBestellingenService BestellingenService, IBestellings_LijstService Bestellings_LijstService, IMenukaartService MenukaartService, IMenuSoortService MenuSoortService)
        {
            _IBestellingenService = BestellingenService;
            _Ibestellings_LijstService = Bestellings_LijstService;
            _ImenukaartService = MenukaartService;
            _IMenuSoortService = MenuSoortService;
        }

        // GET: Bestellingen
        public async Task<IActionResult> Index()
        {
            var Model = await _IBestellingenService.GetAll();
            return View(Model);
        }

        // GET: Bestellingen/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var Bestellingen = await _IBestellingenService.GetById(id);
            if (Bestellingen == null)
            {
                return NotFound();
            }
            foreach (var item in Bestellingen.Bestellingen_Lijst)
            {
                item.menukaart = await _ImenukaartService.GetById(item.MenuKaart_Id);
            }

            return View(Bestellingen);
        }

        // GET: Bestellingen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bestellingen/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bestellingen Model)
        {
            if (ModelState.IsValid)
            {
                await _IBestellingenService.Create(Model);
                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        // GET: Bestellingen/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var Bestellingen = await _IBestellingenService.GetById(id);
            if (Bestellingen == null)
            {

                return NotFound();
            }
            foreach (var item in Bestellingen.Bestellingen_Lijst)
            {
                item.menukaart = await _ImenukaartService.GetById(item.MenuKaart_Id);
            }

            return View(Bestellingen);
        }

        // POST: Bestellingen/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Bestellingen Model)
        {
            if (id != Model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var Bestellingen = await _IBestellingenService.GetById(id);
                if (Bestellingen != null)
                {
                    await _IBestellingenService.Edit(Model);
                }
                else
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        // GET: Bestellingen/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var Bestellingen = await _IBestellingenService.GetById(id);
            if (Bestellingen == null)
            {
                return NotFound();
            }
            return View(Bestellingen);
        }

        // POST: Bestellingen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                var Bestellingen = await _IBestellingenService.GetById(id);
                if (Bestellingen != null)
                {
                    await _IBestellingenService.Delete(Bestellingen);
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Bestellingen/bon_download
        [Obsolete]
        public async Task<IActionResult> Bon_download(int id)
        {
            var Bestellingen = await _IBestellingenService.GetById(id);
            if (Bestellingen == null)
            {
                return NotFound();
            }
            foreach (var item in Bestellingen.Bestellingen_Lijst)
            {
                item.menukaart = await _ImenukaartService.GetById(item.MenuKaart_Id);
            }

            return new ViewAsPdf("downloadbon", Bestellingen)
            {
                FileName = "ExelentTasteBon.pdf"
            };
        }

    }
}
