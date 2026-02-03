using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Upgrade
    {
        public string Name { get; }
        public int Cost { get; }
        public int MoneyPerClick { get; }
        public int Level { get; private set; }

        public Upgrade(string name, int cost, int moneyPerClick)
        {
            Name = name;
            Cost = cost;
            MoneyPerClick = moneyPerClick;
            Level = 0;
        }

        public bool Buy()
        {
            int price = Cost * (Level + 1);
            if (Money.value < price)
                return false;

            Money.value -= price;
            Level++;
            return true;
        }

        public int CurrentPrice() => Cost * (Level + 1);
    }
}
