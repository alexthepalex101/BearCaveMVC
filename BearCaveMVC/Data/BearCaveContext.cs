using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BearCaveMVC.Models;

namespace BearCaveMVC.Models
{
    public class BearCaveContext : DbContext
    {
        public BearCaveContext (DbContextOptions<BearCaveContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
