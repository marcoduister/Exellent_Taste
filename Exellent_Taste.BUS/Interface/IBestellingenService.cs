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
    /// IBestellingenService Interface
    /// </summary>
    public interface IBestellingenService
    {
        /// <summary>
        /// deze funtie haalt alle gegevens op van Bestellingen
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{Bestellingen}"/></returns>
        public Task<IEnumerable<Bestellingen>> GetAll();
        /// <summary>
        /// deze funtie haalt een Bestellingen op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns <see cref="Bestellingen"/></returns>
        public Task<Bestellingen> GetById(int ID);
        /// <summary>
        /// deze funtie maakt een nieuwe Bestellingen met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<Bestellingen> Create(Bestellingen Model);
        /// <summary>
        /// deze funtie update een Bestellingen met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(Bestellingen Model);
        /// <summary>
        /// deze funtie verwijderd een Bestellingen met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(Bestellingen Model);

    }
}
