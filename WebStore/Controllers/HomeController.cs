using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Мигальчинский", FirstName = "Никита", Patronymic = "Михайлович", Age = 18 },
            new Employee { Id = 2, LastName = "Соловьев", FirstName = "Георгий", Patronymic = "Евгеньевич", Age = 19 },
            new Employee { Id = 3, LastName = "Романов", FirstName = "Нияз", Patronymic = "Нияз", Age = 21 }
        };
        public IActionResult Index() => View();

        public IActionResult SecondAction(string id) => Content($"Action with value id: {id}");

        public IActionResult Employees() => View(model:__Employees);
    }
}
