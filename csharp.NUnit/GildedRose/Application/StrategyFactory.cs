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
                "Conjured Mana Cake" => new ConjuredItemStrategy(),
                "Sulfuras, Hand of Ragnaros" => new SulfurasStrategy(),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassStrategy(),
                "Aged Brie" => new AgedBrieStrategy(),
                _ => new BasiqueItemStrategy(),
            };
        }
    }
}
