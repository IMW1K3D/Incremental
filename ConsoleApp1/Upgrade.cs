using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Upgrade
    {
        // Nament på upgraden (typ "Cursor" eller "Grandma")
        public string Name { get; }
        // Grundkostnaden för upgraden
        public int Cost { get; }
        // Hur mycket pengar upgraden ger per klick
        public int MoneyPerClick { get; }
        // Vilken level upgraden är på, kan bara ändras inne i klassen (private set)
        public int Level { get; private set; }

        // Constructor som skapar en ny upgrade
        public Upgrade(string name, int cost, int moneyPerClick)
        {
            Name = name;
            Cost = cost;
            MoneyPerClick = moneyPerClick;
            Level = 0;
        }

        // Försöker köpa upgraden
        public bool Buy()
        {
            int price = Cost * (Level + 1);
            if (Money.value < price)
                return false;

            Money.value -= price;
            Level++;
            return true;
        }

        // Räknar ut nuvarande pris basert på level
        public int CurrentPrice() => Cost * (Level + 1);
    }
}
