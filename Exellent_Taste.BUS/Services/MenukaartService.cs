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
    public class MenukaartService : IMenukaartService
    {
        private readonly ExellentDbContext _DbContext;

        public MenukaartService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IEnumerable<Menukaart>> GetAll()
        {
            return await _DbContext.Menukaart.AsNoTracking().ToListAsync();
        }
        public async Task<Menukaart> GetById(int? ID)
        {
            return await _DbContext.Menukaart.AsNoTracking().Include(m => m.menusoort).FirstAsync(I => I.ID == ID);
        }
        public async Task<bool> Create(Menukaart Model)
        {
            if (!_DbContext.Menukaart.Any(i => i.Naam == Model.Naam))
            {
                _DbContext.Menukaart.Add(Model);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Edit(Menukaart Model)
        {
            if (!_DbContext.Menukaart.Any(i => i.Naam == Model.Naam && i.ID != Model.ID))
            {
                var MenukaartEX = await _DbContext.Menukaart.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (MenukaartEX != null)
                {
                    _DbContext.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<bool> Delete(Menukaart Model)
        {
            var MenukaartEX = await _DbContext.Menukaart.AsNoTracking().FirstAsync(I => I.ID == Model.ID);
            if (MenukaartEX != null)
            {
                _DbContext.Remove(Model);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
