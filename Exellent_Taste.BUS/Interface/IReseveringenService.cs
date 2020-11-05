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
    /// IReseveringenService Interface
    /// </summary>
    public interface IReseveringenService
    {
        /// <summary>
        /// deze funtie haalt alle gegevens op van reseveringen
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{reseveringen}"/></returns>
        public Task<IEnumerable<Reseveringen>> GetAll();
        /// <summary>
        /// deze funtie haalt een resevering op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Task<Reseveringen> GetById(int ID);
        /// <summary>
        /// deze funtie maakt een nieuwe resevering met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Create(Reseveringen Model);
        /// <summary>
        /// deze funtie update een resevering met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(Reseveringen Model);
        /// <summary>
        /// deze funtie verwijderd een resevering met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(Reseveringen Model);

    }

}
