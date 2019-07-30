using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistence
{
    public class MateriaDbContext : DbContext
    {
        public DbSet<Materia> Materia { get; set; }

        public MateriaDbContext(DbContextOptions<MateriaDbContext> opciones) 
            : base(opciones)
        { }
    }
}
