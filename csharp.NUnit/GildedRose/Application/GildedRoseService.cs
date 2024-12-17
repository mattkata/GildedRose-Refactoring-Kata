using System.Collections.Generic;
using GildedRoseKata.Domaine;

namespace GildedRoseKata.Application;

public class GildedRoseService
{
    private readonly IList<Item> _items;

    public GildedRoseService(IList<Item> items)
    {
        this._items = items;
    }

    // Orchestration des mises à jour des items en utilisant la stratégie appropriée.
    public void UpdateQuality()
    {
        foreach (var item in _items)
        {

            var strategy = StrategyFactory.GetStrategy(item.Name);
            strategy.Update(item);




            //if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //{
            //    if (Items[i].Quality > 0)
            //    {
            //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //        {
            //            Items[i].Quality = Items[i].Quality - 1;
            //        }
            //    }
            //}
            //else
            //{
            //    if (Items[i].Quality < 50)
            //    {
            //        Items[i].Quality = Items[i].Quality + 1;

            //        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            //        {
            //            if (Items[i].SellIn < 11)
            //            {
            //                if (Items[i].Quality < 50)
            //                {
            //                    Items[i].Quality = Items[i].Quality + 1;
            //                }
            //            }

            //            if (Items[i].SellIn < 6)
            //            {
            //                if (Items[i].Quality < 50)
            //                {
            //                    Items[i].Quality = Items[i].Quality + 1;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //{
            //    Items[i].SellIn = Items[i].SellIn - 1;
            //}

            //if (Items[i].SellIn < 0)
            //{
            //    if (Items[i].Name != "Aged Brie")
            //    {
            //        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //        {
            //            if (Items[i].Quality > 0)
            //            {
            //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                {
            //                    Items[i].Quality = Items[i].Quality - 1;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Items[i].Quality = Items[i].Quality - Items[i].Quality;
            //        }
            //    }
            //    else
            //    {
            //        if (Items[i].Quality < 50)
            //        {
            //            Items[i].Quality = Items[i].Quality + 1;
            //        }
            //    }
            //}
        }
    }
}