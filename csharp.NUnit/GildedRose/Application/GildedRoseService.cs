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
        }
    }
}