using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exellent_Taste.BUS.Interface;
using Exellent_Taste.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exellent_Taste.WEB.Controllers
{
    public class Bestellings_LijstController : Controller
    {
        private readonly IBestellings_LijstService _Ibestellings_LijstService;
        private readonly IMenukaartService _ImenukaartService;
        private readonly IBestellingenService _IBestellingenService;

        public Bestellings_LijstController(IBestellings_LijstService Bestellings_LijstService, IMenukaartService MenukaartService, IBestellingenService BestellingenService)
        {
            _Ibestellings_LijstService = Bestellings_LijstService;
            _ImenukaartService = MenukaartService;
            _IBestellingenService = BestellingenService;
        }

        // deze funtie maakt voeged een menukaart item toe aan bestelling
        // POST: Bestellings_Lijst/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync()
        {
            var Id = HttpContext.Request.Form["ID"];
            var submitid = HttpContext.Request.Form["buttonsubmit"];
            var Dropdown = string.Empty;
            try
            {
                if (submitid == 2.ToString())
                {
                    Dropdown = HttpContext.Request.Form["drankDropdown"];
                }
                else
                {
                    Dropdown = HttpContext.Request.Form["voedselDropdown"];
                }
                if (Dropdown != "-1" && Dropdown != null)
                {
                    var bestellingrijst = new Bestellingen_Lijst()
                    {
                        Bestelling_Id = int.Parse(Id),
                        MenuKaart_Id  = int.Parse(Dropdown)
                    };
                    var order = await _Ibestellings_LijstService.Create(bestellingrijst);

                    var bestelling = await _IBestellingenService.GetById(int.Parse(Id));
                    if (bestelling != null)
                    {
                        bestelling.Totaal += order.menukaart.Prijs;
                    }
                    await _IBestellingenService.Edit(bestelling);
                }
                return RedirectToAction("Edit", "Bestellings", new { id = int.Parse(Id) });
            }
            catch
            {
                return RedirectToAction("Edit", "Bestellings", new { id = int.Parse(Id) });
            }
        }

        // deze funtie verwijderd een menukaart item van een bestelling met behulpt van het id
        // GET: Bestellings_Lijst/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // deze funtie haalt alle bestelling items op voor barman die nog niet geleverd zijn
        // get: Bestellings_Lijst/barmanview
        public async Task<IActionResult> barmanview()
        {
            var Model = await _Ibestellings_LijstService.GetAll();
            if (Model == null)
            {
                return NotFound();
            }
            return View(Model);
        }

        // POST: Bestellings_Lijst/geleverd/5
        public async Task<IActionResult> geleverd(int id)
        {

                var bestellingen_Lijst = await _Ibestellings_LijstService.GetById(id);
                if (bestellingen_Lijst != null)
                {
                    bestellingen_Lijst.Geleverd = true;
                    await _Ibestellings_LijstService.Edit(bestellingen_Lijst);
                }
                else
                {
                    return NotFound();
                }
            return RedirectToAction("barmanview", "Bestellings_Lijst");
        }
    }
}