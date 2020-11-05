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
    public class ReseveringenService : IReseveringenService
    {
        private readonly ExellentDbContext _DbContext;

        public ReseveringenService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IEnumerable<Reseveringen>> GetAll()
        {
            return await _DbContext.Reseveringen.AsNoTracking().ToListAsync();
        }
        public async Task<Reseveringen> GetById(int ID)
        {
            return await _DbContext.Reseveringen.AsNoTracking().Include(i => i.Adress).FirstAsync(I => I.ID == ID);
        }
        public async Task<bool> Create(Reseveringen Model)
        {
            if (!_DbContext.Reseveringen.Any(i => i.Email == Model.Email))
            {
                _DbContext.Reseveringen.Add(Model);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Edit(Reseveringen Model)
        {
            if (_DbContext.Reseveringen.Any(i => i.Email == Model.Email && i.ID != Model.ID))
            {
                var ReseveringenEX = await _DbContext.Reseveringen.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (ReseveringenEX != null)
                {
                    _DbContext.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<bool> Delete(Reseveringen Model)
        {
            var ReseveringenEX = await _DbContext.Reseveringen.AsNoTracking().FirstAsync(I => I.ID == Model.ID);
            if (ReseveringenEX != null)
            {
                _DbContext.Remove(Model);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
