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
    public class GebruikersService : IGebruikersService
    {
        private readonly ExellentDbContext _DbContext;

        public GebruikersService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IEnumerable<Gebruikers>> GetAll()
        {
            return await _DbContext.Gebruikers.AsNoTracking().ToListAsync(); ;
        }
        public async Task<Gebruikers> GetById(int ID)
        {
            return await _DbContext.Gebruikers.AsNoTracking().FirstAsync(I => I.ID == ID);
        }
        public async Task<bool> Create(Gebruikers Model)
        {
            if (!_DbContext.Gebruikers.Any(i => i.Email == Model.Email))
            {
                _DbContext.Gebruikers.Add(Model);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Edit(Gebruikers Model)
        {
            if (!_DbContext.Gebruikers.Any(i => i.Email == Model.Email && i.ID != Model.ID))
            {
                var GebruikersEX = await _DbContext.Gebruikers.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (GebruikersEX != null)
                {
                    _DbContext.Gebruikers.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<bool> Delete(Gebruikers Model)
        {
            var GebruikersEX = await _DbContext.Gebruikers.AsNoTracking().FirstAsync(I => I.ID == Model.ID);
            if (GebruikersEX != null)
            {
                _DbContext.Remove(Model);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
