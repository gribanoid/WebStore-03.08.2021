using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Николаев", FirstName = "Григорий", Patronymic = "Андреевич", Age = 18 },
            new Employee { Id = 2, LastName = "Соловьев", FirstName = "Георгий", Patronymic = "Евгеньевич", Age = 19 },
            new Employee { Id = 3, LastName = "Романов", FirstName = "Нияз", Patronymic = "Нияз", Age = 21 }
        };
        public IActionResult Index() => View(__Employees);
    }
}
