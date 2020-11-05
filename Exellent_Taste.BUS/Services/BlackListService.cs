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
    public class BlackListService : IBlackListService
    {
        private readonly ExellentDbContext _DbContext;

        public BlackListService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IEnumerable<BlackList>> GetAll()
        {
            return await _DbContext.BlackList.AsNoTracking().ToListAsync(); ;
        }
        public async Task<BlackList> GetByEmail(string Email)
        {
            var blacklist = await _DbContext.BlackList.AsNoTracking().SingleAsync(I => I.Email == Email);
            return blacklist;
        }
        public async Task<bool> Create(BlackList Model)
        {
            if (!_DbContext.BlackList.Any(i => i.Email == Model.Email))
            {
                _DbContext.BlackList.Add(Model);
                await _DbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Edit(BlackList Model)
        {
            if (!_DbContext.BlackList.Any(i => i.Email == Model.Email && i.ID != Model.ID))
            {
                var BlackListEX = await _DbContext.BlackList.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (BlackListEX != null)
                {
                     _DbContext.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
        public async Task<bool> Delete(BlackList Model)
        {
            var BlackListEX = await _DbContext.BlackList.FirstAsync(I => I.ID == Model.ID);
            if (BlackListEX != null)
            {
                _DbContext.Remove(Model);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
