using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entiteti;
using Entity.Interfesji;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Entity.Servisi
{
    public class KartaServis
    {
        private IZeleznickaStanicaDbContext dbContext;


        public KartaServis(IZeleznickaStanicaDbContext dbContext)

        {
            this.dbContext = dbContext;
        }

        public KartaServis()
        {

        }

        public async Task<List<Karta>> PreuzmiKarte(string mestoPolaskaFilter = default, string mestoDolaskaFilter = default, DateTime vremePolaskaFilter = default, string tipKarte = default)
        {
            IQueryable<Karta> karte = dbContext.Karte;

            if (!string.IsNullOrEmpty(mestoPolaskaFilter))
                karte = karte.Where(karta => karta.MestoPolaska.Contains(mestoPolaskaFilter));

            if (!string.IsNullOrEmpty(mestoDolaskaFilter))
                karte = karte.Where(karta => karta.MestoDolaska.Contains(mestoDolaskaFilter));

            if (vremePolaskaFilter != default)
            {
                karte = karte.Where(karta => karta.VremePolaska == vremePolaskaFilter);
            }
            if (!string.IsNullOrEmpty(tipKarte))
                karte = karte.Where(karta => karta.TipKarte.Contains(tipKarte));

            return await karte.ToListAsync();
        }

        public async Task DodajKartu(Karta karta)
        {   
            dbContext.Karte.Add(karta);
            await dbContext.SaveChangesAsync();
        }

        public async Task IzmeniKartu(Guid id, Karta izmenjenaKarta)
        {
            Karta? staraKarta = await dbContext.Karte.FindAsync(id);
            if (staraKarta is null) throw new KeyNotFoundException("Karta ne postoji!");

            staraKarta.MestoPolaska = izmenjenaKarta.MestoPolaska;
            staraKarta.MestoDolaska = izmenjenaKarta.MestoDolaska;
            staraKarta.VremePolaska = izmenjenaKarta.VremePolaska;
            staraKarta.TipKarte = izmenjenaKarta.TipKarte;

            await dbContext.SaveChangesAsync();
        }

        public async Task ObrisiKartu(Guid id)
        {
            Karta? kartaZaBrisanje = await dbContext.Karte.FindAsync(id);
            if (kartaZaBrisanje is null) throw new KeyNotFoundException("Karta ne postoji!");
            dbContext.Karte.Remove(kartaZaBrisanje);
            await dbContext.SaveChangesAsync();
        }
    }
}
