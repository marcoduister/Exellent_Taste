using Exellent_Taste.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exellent_Taste.BUS.Interface
{
    /// <summary>
    /// IGebruikersService Interface
    /// </summary>
    public interface IGebruikersService
    {
        /// <summary>
        /// deze funtie haalt alle gegevens op van Gebruikers
        /// </summary>
        /// <returns>Returns <see cref="IEnumerable{Gebruikers}"/></returns>
        public Task<IEnumerable<Gebruikers>> GetAll();
        /// <summary>
        /// deze funtie haalt een Gebruikers op met behulpt van ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns <see cref="Gebruikers"/></returns>
        public Task<Gebruikers> GetById(int ID);
        /// <summary>
        /// deze funtie maakt een nieuwe Gebruikers met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Create(Gebruikers Model);
        /// <summary>
        /// deze funtie update een Gebruikers met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Edit(Gebruikers Model);
        /// <summary>
        /// deze funtie verwijderd een Gebruikers met behulpt van model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Returns <see cref="bool"/></returns>
        public Task<bool> Delete(Gebruikers Model);

    }
}
