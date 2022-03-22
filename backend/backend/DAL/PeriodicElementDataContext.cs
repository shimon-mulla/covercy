using backend.BE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DAL
{
    public class PeriodicElementDataContext:DbContext
    {
        public DbSet<PeriodicElement> PeriodicElements { get; set; }
        public PeriodicElementDataContext() : base() { }

        public PeriodicElementDataContext(DbContextOptions<PeriodicElementDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }
    }
}
