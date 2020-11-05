using Exellent_Taste.BUS.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Exellent_Taste.DAL;
using Microsoft.EntityFrameworkCore;
using Exellent_Taste.Models;
using Exellent_Taste.BUS.Interface;

namespace Exellent_Taste.BUS.Services
{
    public class AccountService : IAccountService
    {
        private readonly ExellentDbContext _DbContext;
        /// <summary>
        /// AccountService constructor
        /// </summary>
        /// <param name="DbContext"></param>
        public AccountService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        // dit haalt verglijkt als gebruiker met model gegevens bestaat en stuurt er naar volegdigen model naar controller

        public async Task<Gebruikers> GetByInfo(LoginModel Model)
        {
            if (_DbContext.Gebruikers.Any(I => I.Email == Model.Email && I.Wachtwoord == Model.Password))
            {
                return await _DbContext.Gebruikers.AsNoTracking().FirstAsync(I => I.Email == Model.Email && I.Wachtwoord == Model.Password);
            }
            else
            {
                return null;
            }
        }
    }
}


