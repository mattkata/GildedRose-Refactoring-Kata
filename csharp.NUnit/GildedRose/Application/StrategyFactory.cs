using GildedRoseKata.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Application
{
    public class StrategyFactory
    {
        public static IUpdateStrategy GetStrategy(string itemName)
        {
            return itemName switch
            {
                _ => new BasiqueItemStrategy(),
            };
        }
    }
}
