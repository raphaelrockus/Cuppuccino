//using Blazored.Toast.Services;
using Cuppuccino.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuppuccino.Client.Services
{
    public class CoffeeService : ICoffeeService
    {
        //private readonly IToastService _toastService;

        //public CoffeeService(IToastService toastService)
        //{
        //    this._toastService = toastService;
        //}

        //Simulation de la base de données
        public IList<Coffee> Coffees => new List<Coffee>
        {
            new Coffee{Id = 1, Name="Black", Cost = 100},
            new Coffee{Id = 2, Name="Latte", Cost = 200},
            new Coffee{Id = 3, Name="Expresso", Cost = 250},
            new Coffee{Id = 4, Name="ColdBrew", Cost = 100},
            new Coffee{Id = 5, Name="Christmas Brew", Cost = 1000}
        };

        public IList<UserCoffee> MyCoffees { get; set; } = new List<UserCoffee>();

        public void AddCoffee(int coffeeId)
        {
            var coffee = Coffees.First(coffee => coffee.Id == coffeeId);
            MyCoffees.Add(new UserCoffee { CoffeeId = coffee.Id });
            //_toastService.ShowSuccess($"Your {unit.Name} has been built!, Unit built!");
        }

        //public void AddUnit(int unitId)
        //{
        //    var unit = Units.First(unit => unit.Id == unitId);
        //    MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
        //    _toastService.ShowSuccess($"Your {unit.Title} has been built!, Unit built!");

        //}
    }
}
