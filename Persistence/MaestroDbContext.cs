using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistence
{
    public class MaestroDbContext : DbContext
    {
        public DbSet<Maestro> Maestro { get; set; }

        public MaestroDbContext(DbContextOptions<MaestroDbContext> opciones) : base(opciones)
        { }
    }
}
