using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcAsp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Selers { get; set; } = new List<Seller>();
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeler ( Seller seller)
        {
            Selers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Selers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
