using SalesMvcAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcAsp.Data
{
    public class SeedingService
    {
        private SalesMvcAspContext _context;
        public SeedingService(SalesMvcAspContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SallesRecord.Any())
                return;//Banco de dados já foi populado

            Department d1 = new Department( 1, "Computer" );
            Department d2 = new Department( 1, "Eletronicos" );
            Department d3 = new Department( 1, "Carros" );

            Seller s1 = new Seller(1, "Bob", "bob", 1000.0, DateTime.Now, d1);
        }
    }
}
