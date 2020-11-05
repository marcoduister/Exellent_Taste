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
    public class MenuSoortService : IMenuSoortService
    {
        private readonly ExellentDbContext _DbContext;

        public MenuSoortService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IEnumerable<Menusoort>> GetAll()
        {
            return await _DbContext.Menusoort.AsNoTracking().ToListAsync(); ;
        }
        public async Task<IEnumerable<Menusoort>> GetAllbyId(int ID)
        {
            return await _DbContext.Menusoort.AsNoTracking().ToListAsync(); ;
        }

        public async Task<Menusoort> GetById(int? ID)
        {
            return await _DbContext.Menusoort.AsNoTracking().FirstAsync(I => I.ID == ID);
        }
        public async Task<bool> Create(Menusoort Model)
        {
            if (!_DbContext.Menusoort.Any(i => i.Naam == Model.Naam))
            {
                _DbContext.Menusoort.Add(Model);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Edit(Menusoort Model)
        {
            if (!_DbContext.Menusoort.Any(i => i.Naam == Model.Naam && i.ID != Model.ID))
            {
                var MenusoortEX = await _DbContext.Menusoort.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (MenusoortEX != null)
                {
                    _DbContext.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<bool> Delete(Menusoort Model)
        {
            var MenusoortEX = await _DbContext.Menusoort.AsNoTracking().FirstAsync(I => I.ID == Model.ID);
            if (MenusoortEX != null)
            {
                _DbContext.Remove(Model);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
