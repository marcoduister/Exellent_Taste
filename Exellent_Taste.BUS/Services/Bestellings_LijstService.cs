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
    public class Bestellings_LijstService : IBestellings_LijstService
    {
        private readonly ExellentDbContext _DbContext;

        public Bestellings_LijstService(ExellentDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<Bestellingen_Lijst> GetById(int ID)
        {
            return await _DbContext.Bestellingen_Lijst.Include(a=>a.bestellingen).Include(a=>a.menukaart).AsNoTracking().FirstAsync(I => I.ID == ID);
        }
        public async Task<Bestellingen_Lijst> Create(Bestellingen_Lijst Model)
        {
            if (Model !=null)
            {


                var bestellingen_Lijst = new Bestellingen_Lijst();
                bestellingen_Lijst = Model;
                _DbContext.Bestellingen_Lijst.Add(bestellingen_Lijst);

                await _DbContext.SaveChangesAsync();
                var menu = _DbContext.Menukaart.AsNoTracking().First(i => i.ID == Model.MenuKaart_Id);
                var bestelling =_DbContext.Bestellingen.AsNoTracking().First(i => i.ID == Model.Bestelling_Id);
                bestelling.Totaal += menu.Prijs;
                _DbContext.Bestellingen.Update(bestelling);
                await _DbContext.SaveChangesAsync();
                return bestellingen_Lijst;
            }
            return Model;
        }
        public async Task<bool> Delete(Bestellingen_Lijst Model)
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

        //deze funtie haalt alles op van bestelling_lijst op geleverde order met menu en bestellingen er bij
        public async Task<IEnumerable<Bestellingen_Lijst>> GetAll()
        {
            return await _DbContext.Bestellingen_Lijst.AsNoTracking().Include(i => i.menukaart).Include(i => i.bestellingen).OrderBy(x => x.Geleverd).ToListAsync();
        }

        // deze funtie  edit de geleverde status van een bestelling
        public async Task<bool> Edit(Bestellingen_Lijst Model)
        {
            if (_DbContext.Bestellingen_Lijst.Any(i => i.ID == Model.ID))
            {
                var bestellingen_Lijst_EX = await _DbContext.Bestellingen_Lijst.AsNoTracking().FirstOrDefaultAsync(i => i.ID == Model.ID);
                if (bestellingen_Lijst_EX != null)
                {
                    _DbContext.Update(Model);
                    await _DbContext.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
