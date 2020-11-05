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
    /// IBestellings_LijstService Interface
    /// </summary>
    public interface IBestellings_LijstService
    {
        /// <summary>
        /// deze funtie haalt alle gegevens op van Bestellingen_Lijst
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{Bestellingen_Lijst}"/></returns>
        public Task<IEnumerable<Bestellingen_Lijst>> GetAll();
        /// <summary>
        /// deze funtie haalt een Bestellingen_Lijst op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns <see cref="Bestellingen_Lijst"/></returns>
        public Task<Bestellingen_Lijst> GetById(int id);
        /// <summary>
        /// deze funtie maakt een nieuwe Bestellingen_Lijst met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<Bestellingen_Lijst> Create(Bestellingen_Lijst Model);
        /// <summary>
        /// deze funtie update een Bestellingen_Lijst met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(Bestellingen_Lijst Model);
        /// <summary>
        /// deze funtie verwijderd een Bestellingen_Lijst met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(Bestellingen_Lijst bestellingen_Lijst);
    }
}
