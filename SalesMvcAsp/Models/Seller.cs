using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcAsp.Models
{
    public class Seller // classe vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; } //data nascimento
        public Department Department_ { get; set; }
        public ICollection<SallesRecord> Salles = new List<SallesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department_)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department_ = department_;
        }

        public void AddSales (SallesRecord sr)
        {
            Salles.Add(sr);
        }

        public void RemoveSales(SallesRecord sr)
        {
            Salles.Remove(sr);  
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Salles.Where(n => n.Date >= initial && n.Date <= final).Sum(n => n.Amount);
        }
    }
}
