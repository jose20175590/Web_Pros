using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistence
{
    public class AulaDbContext : DbContext
    {
        public DbSet<Aula> Aula { get; set; }

        public AulaDbContext(DbContextOptions<AulaDbContext> opciones) : base(opciones)
        { }
    }
}
