using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Upgrades
    {
        public List<Upgrade> All { get; } = new List<Upgrade>()
    {
        new Upgrade("Cursor", 10, 1),
        new Upgrade("Grandma", 50, 5)
    };

        public bool BuyUpgrade(int index)
        {
            if (index < 0 || index >= All.Count)
                return false;

            return All[index].Buy();
        }

        public void PrintStats()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Money: {Money.value}   ");
            Console.WriteLine();

            for (int i = 0; i < All.Count; i++)
            {
                var u = All[i];
                Console.WriteLine(
                    $"{i + 1}. {u.Name} | Cost: {u.CurrentPrice()} | Level: {u.Level} | +{u.MoneyPerClick}/click"
                );
            }
        }
    }
}
