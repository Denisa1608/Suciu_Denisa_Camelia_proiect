using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Suciu_Denisa_Camelia_proiect.Models;

namespace Suciu_Denisa_Camelia_proiect.Data
{
    public class Suciu_Denisa_Camelia_proiectContext : DbContext
    {
        public Suciu_Denisa_Camelia_proiectContext (DbContextOptions<Suciu_Denisa_Camelia_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; } = default!;
    }
}
