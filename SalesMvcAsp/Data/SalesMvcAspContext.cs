using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMvcAsp.Models;

namespace SalesMvcAsp.Data
{
    public class SalesMvcAspContext : DbContext
    {
        public SalesMvcAspContext (DbContextOptions<SalesMvcAspContext> options)
            : base(options)
        {
        }

        public DbSet<SalesMvcAsp.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SallesRecord> SallesRecord { get; set; }
    }
}
