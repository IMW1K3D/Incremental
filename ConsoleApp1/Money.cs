using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Money
    {
        static Upgrades upgrades = new Upgrades();
        static public int value = 0;
        static void Main(string[] args)
        {
            upgrades.PrintStats();
            while (true)
            {
                var key = Console.ReadKey(true);
                
                if (key.Key >= ConsoleKey.D1 && key.Key <= ConsoleKey.D9)
                {
                    int index = key.Key - ConsoleKey.D1;
                    upgrades.BuyUpgrade(index);
                    upgrades.PrintStats();
                }

                if (key.Key == ConsoleKey.Spacebar)
                {
                    int gain = 1;

                    foreach (var u in upgrades.All)
                        gain += u.Level * u.MoneyPerClick;


                    Money.value += gain;
                    upgrades.PrintStats();
                }
            }
        }
    }
}
