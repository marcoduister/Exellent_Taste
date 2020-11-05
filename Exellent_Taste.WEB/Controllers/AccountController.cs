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
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Exellent_Taste.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _AccountService;


        public AccountController(IAccountService AccountService)
        {
            _AccountService = AccountService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var Accountdetails = await _AccountService.GetByInfo(model);
                if (Accountdetails == null)
                {
                    ModelState.AddModelError("Password", "Invalid login attempt.");
                    return View("Index");
                }
                HttpContext.Session.SetString("GebruikersId", Accountdetails.ID.ToString());
                HttpContext.Session.SetString("GebruikersNaam", Accountdetails.Voornaam +" "+ Accountdetails.Achternaam);
                HttpContext.Session.SetString("GebruikersEmail", Accountdetails.Email);
            }
            else
            {
                return View("Index");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
        public void ValidationMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }
        }
    }
}