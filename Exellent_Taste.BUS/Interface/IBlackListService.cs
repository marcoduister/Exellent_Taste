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
    /// IBlackListService Interface
    /// </summary>
    public interface IBlackListService
    {
        /// <summary>
        /// deze funtie haalt alle gegevens op van BlackList
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{BlackList}"/></returns>
        public Task<IEnumerable<BlackList>> GetAll();
        /// <summary>
        /// deze funtie haalt een BlackList op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns <see cref="BlackList"/></returns>
        public Task<BlackList> GetByEmail(string Email);
        /// <summary>
        /// deze funtie maakt een nieuwe BlackList met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Create(BlackList Model);
        /// <summary>
        /// deze funtie update een BlackList met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(BlackList Model);
        /// <summary>
        /// deze funtie verwijderd een BlackList met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(BlackList Model);

    }
}
