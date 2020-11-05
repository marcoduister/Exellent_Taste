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
    /// IMenukaartService Interface
    /// </summary>
    public interface IMenukaartService
        {
        /// <summary>
        /// deze funtie haalt alle gegevens op van Menukaart
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{Menukaart}"/></returns>
        public Task<IEnumerable<Menukaart>> GetAll();
        /// <summary>
        /// deze funtie haalt een Menukaart op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns <see cref="Menukaart"/></returns>
        public Task<Menukaart> GetById(int? ID);
        /// <summary>
        /// deze funtie maakt een nieuwe Menukaart met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Create(Menukaart Model);
        /// <summary>
        /// deze funtie update een Menukaart met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(Menukaart Model);
        /// <summary>
        /// deze funtie verwijderd een Menukaart met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(Menukaart Model);
    }
}
