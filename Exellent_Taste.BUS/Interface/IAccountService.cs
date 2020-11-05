using Exellent_Taste.BUS.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Exellent_Taste.DAL;
using Microsoft.EntityFrameworkCore;
using Exellent_Taste.Models;

namespace Exellent_Taste.BUS.Interface
{
    /// <summary>
    /// IAccountService Interface
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        ///  haalt gegevens op van gebruiker met behulpt van model inhoud
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public Task<Gebruikers> GetByInfo(LoginModel Model);
    }
}
