using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesMvcAsp.Models;

namespace SalesMvcAsp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDepartments = new List<Department>();
            listDepartments.Add(new Department { Id = 1, Name = "Jogos" });
            listDepartments.Add(new Department { Id = 2, Name = "Motos" });
            listDepartments.Add(new Department { Id = 3, Name = "Carros" });

            return View(listDepartments);
        }
    }
}
