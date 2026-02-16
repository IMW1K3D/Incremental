using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Upgrades
    {
        // Lista med alla upgrades som finns i spelet
        public List<Upgrade> All { get; } = new List<Upgrade>()
    {
        new Upgrade("Cursor", 10, 1),
        new Upgrade("Grandma", 50, 5)
    };
        // Köper en upgrade baserat på index (typ 0 för Cursor, 1 för Grandma)
        public bool BuyUpgrade(int index)
        {
            if (index < 0 || index >= All.Count)
                return false;

            return All[index].Buy();
        }
        // Skriver ut statistik på skärmen (konsolen)
        public void PrintStats()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Money: {Money.value}   ");
            Console.WriteLine();

            for (int i = 0; i < All.Count; i++)
            {
                var u = All[i];
                // Skriver ut nummer, namn, pris, level och hur mycket den get per klick
                Console.WriteLine(
                    $"{i + 1}. {u.Name} | Cost: {u.CurrentPrice()} | Level: {u.Level} | +{u.MoneyPerClick}/click"
                );
            }
        }
    }
}
