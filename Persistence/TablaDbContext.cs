using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class TablaDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Maestro> Maestro { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public TablaDbContext(DbContextOptions<TablaDbContext> opciones) : base(opciones)
        { }
    }
}
