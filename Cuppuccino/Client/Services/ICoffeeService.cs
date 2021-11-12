using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cuppuccino.Shared;

namespace Cuppuccino.Client.Services
{
    public interface ICoffeeService
    {
        IList<Coffee> Coffees { get; }
        IList<UserCoffee> MyCoffees { get; set; }
        void AddCoffee(int unitId);
    }
}
