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
{    /// <summary>
     /// IMenuSoortService Interface
     /// </summary>
    public interface IMenuSoortService
    {
        /// <summary>
        /// deze funtie haalt alle gegevens op van Menusoort
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{Menusoort}"/></returns>
        public Task<IEnumerable<Menusoort>> GetAll();
        /// <summary>
        /// deze funtie haalt all Menusoort op met behulpt van ID
        /// </summary>
        /// <param name="GetAllbyId"></param>
        /// <returns>Returns <see cref="IEnumerable{Menusoort}"/></returns>
        public Task<IEnumerable<Menusoort>> GetAllbyId(int GetAllbyId);
        /// <summary>
        /// deze funtie haalt een Menusoort op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns <see cref="Menusoort"/></returns>
        public Task<Menusoort> GetById(int? ID);
        /// <summary>
        /// deze funtie maakt een nieuwe Menusoort met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Create(Menusoort Model);
        /// <summary>
        /// deze funtie update een Menusoort met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(Menusoort Model);
        /// <summary>
        /// deze funtie verwijderd een Menusoort met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(Menusoort Model);

    }
}
