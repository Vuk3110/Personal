using Entity.Entiteti;
using Entity.Interfesji;
using Microsoft.EntityFrameworkCore;

namespace Baza
{
    public class ZeleznickaStanicaDbContext : DbContext, IZeleznickaStanicaDbContext
    {
        private const string KONEKCIONI_STRING = @"Data Source=DESKTOP-45OV23N;Initial Catalog=ZeleznickaStanicaDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DbSet<Karta> Karte => Set<Karta>();

        

        public ZeleznickaStanicaDbContext()
        {

        }

                public ZeleznickaStanicaDbContext(DbContextOptions<ZeleznickaStanicaDbContext> opcije) : base(opcije) { }

        protected override void OnConfiguring(DbContextOptionsBuilder izgradjivacOpcija)
        {
            izgradjivacOpcija.UseSqlServer(KONEKCIONI_STRING);

        }
    }
}