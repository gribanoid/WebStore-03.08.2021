using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    internal static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, LastName = "Николаев", FirstName = "Григорий", Patronymic = "Андреевич", Age = 18 },
            new Employee { Id = 2, LastName = "Соловьев", FirstName = "Георгий", Patronymic = "Евгеньевич", Age = 19 },
            new Employee { Id = 3, LastName = "Романов", FirstName = "Нияз", Patronymic = "Нияз", Age = 21 }
        };
    }
}
