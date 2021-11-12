using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuppuccino.Client.Services
{
    public interface IMoneyService
    {
        event Action OnChange;

        int Money { get; set; }

        void SpendMoney(int amount);
        void AddMoney(int amount);

    }
}
