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
    public class BestellingenService : IBestellingenService
    {
        private readonly ExellentDbContext _DbContext;
        /// <summary>
        /// BestellingenService constructor
        /// </summary>
        /// <param name="DbContext"></param>
        public BestellingenService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<IEnumerable<Bestellingen>> GetAll()
        {
            return await _DbContext.Bestellingen.AsNoTracking().ToListAsync(); ;
        }
        public async Task<Bestellingen> GetById(int ID)
        {
            return await _DbContext.Bestellingen
                .Include(A => A.Bestellingen_Lijst)
                .AsNoTracking()
                .FirstAsync(I => I.ID == ID);
        }
        public async Task<Bestellingen> Create(Bestellingen Model)
        {
            if (Model !=null)
            {
                var Bestellingen = new Bestellingen();
                Bestellingen = Model;
                _DbContext.Bestellingen.Add(Bestellingen);
                
                await _DbContext.SaveChangesAsync();

                return Bestellingen;
            }
            return Model;
        }
        public async Task<bool> Edit(Bestellingen Model)
        {
            if (!_DbContext.Bestellingen.Any(i => i.Tafel == Model.Tafel && i.ID != Model.ID))
            {
                var BestellingenEX = await _DbContext.Bestellingen.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (BestellingenEX != null)
                {
                    _DbContext.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<bool> Delete(Bestellingen Model)
        {
            var BestellingenEX = await _DbContext.Bestellingen.AsNoTracking().FirstAsync(I => I.ID == Model.ID);
            if (BestellingenEX != null)
            {
                _DbContext.Remove(Model);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
