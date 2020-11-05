using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exellent_Taste.DAL;
using Exellent_Taste.Models;
using Exellent_Taste.BUS.Interface;

namespace Exellent_Taste.WEB.Controllers
{
    public class MenukaartsController : Controller
    {
        private readonly IMenukaartService _IMenukaartService;
        private readonly IMenuSoortService _IMenuSoortService;

        //constructor
        public MenukaartsController( IMenukaartService MenukaartService, IMenuSoortService MenuSoortService)
        {
            _IMenukaartService = MenukaartService;
            _IMenuSoortService = MenuSoortService;
        }

        #region Read

        // Deze funtie haalt alle menukaart item op.
        // GET: Menukaarts
        public async Task<IActionResult> Index()
        {
            var Model = await _IMenukaartService.GetAll();
            return View(Model);
        }

        // Deze funtie haalt single menukaart item op met behulpt van single id
        // GET: Menukaarts/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var MenuKaart = await _IMenukaartService.GetById(id);
            if (MenuKaart == null)
            {
                return NotFound();
            }

            return View(MenuKaart);
        }
        
        #endregion

        #region Create

        // GET: Menukaarts/Create
        public IActionResult Create()
        {
            return View();
        }

        // Deze funtie maakt een menukaart item met behulpt van model data
        // POST: Menukaarts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naam,Beschrijving,Prijs,MenuSoort_id,ID,Created_Gebruiker_Id,Updated_Gebruiker_Id,Created_Datum,Updated_Datum")] Menukaart Model)
        {
            if (ModelState.IsValid)
            {
                await _IMenukaartService.Create(Model);
                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        #endregion

        #region bewerk

        // Deze funtie haalt single menukaart item op met behulpt van single id
        // GET: Menukaarts/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var MenuKaart = await _IMenukaartService.GetById(id);
            if (MenuKaart == null)
            {
                return NotFound();
            }
            return View(MenuKaart);
        }

        // Deze funtie bewerkt een menukaart item met behulpt van model data
        // POST: Menukaarts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Naam,Beschrijving,Prijs,MenuSoort_id,ID,Created_Gebruiker_Id,Updated_Gebruiker_Id,Created_Datum,Updated_Datum")] Menukaart Model)
        {
            if (id != Model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var MenuKaart = await _IMenukaartService.GetById(id);
                if (MenuKaart != null)
                {
                    await _IMenukaartService.Edit(Model);
                }
                else
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(Model);
        }

        #endregion

        #region Delete

        // Deze funtie haalt single menukaart item op met behulpt van single id
        // GET: Menukaarts/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var MenuKaart = await _IMenukaartService.GetById(id);
            if (MenuKaart == null)
            {
                return NotFound();
            }
            return View(MenuKaart);
        }

        //deze funtie verwijderd menukaart item met behulp van single id
        // POST: Menukaarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                var MenuKaart = await _IMenukaartService.GetById(id);
                if (MenuKaart != null)
                {
                    await _IMenukaartService.Delete(MenuKaart);
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region fetchdropdownMenu

        public async Task<JsonResult> FetchMenuAsync() // its a GET, not a POST
        {
            var menukaart = await _IMenukaartService.GetAll();

                foreach (var item in menukaart)
                {
                    var menusoort = _IMenuSoortService.GetById(item.MenuSoort_id).GetAwaiter().GetResult();
                    if (menusoort.ID == 17 || menusoort.MenuSoortID == 1)
                    {
                        menukaart = menukaart.Where(u => u.ID != item.ID).ToList();
                    }
                }
            
            return Json(menukaart);

        }
        public async Task<JsonResult> FetchdrinkAsync() // its a GET, not a POST
        {
            var menukaart = await _IMenukaartService.GetAll();

            foreach (var item in menukaart)
            {
                var menusoort = _IMenuSoortService.GetById(item.MenuSoort_id).GetAwaiter().GetResult();
                if (menusoort.ID != 17 && menusoort.MenuSoortID != 1)
                {
                    menukaart = menukaart.Where(u => u.ID != item.ID).ToList();
                }
            }

            return Json(menukaart);

        }

        #endregion

    }
}
