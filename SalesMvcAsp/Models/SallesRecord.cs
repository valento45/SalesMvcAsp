using SalesMvcAsp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcAsp.Models
{
    public class SallesRecord //vendas efetuado por vendedor
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalleStatus Status { get; set; }
        public Seller Seller_ { get; set; }
        public SallesRecord() { }

        public SallesRecord(int id, DateTime date, double amount, SalleStatus status, Seller seller_)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller_ = seller_;
        }
    }
}
