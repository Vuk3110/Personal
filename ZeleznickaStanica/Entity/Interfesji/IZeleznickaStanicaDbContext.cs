using Entity.Entiteti;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Interfesji
{
    public interface IZeleznickaStanicaDbContext
    {
        public DbSet<Karta> Karte { get; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
