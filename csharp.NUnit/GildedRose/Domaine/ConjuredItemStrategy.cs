
using System;

namespace GildedRoseKata.Domaine
{
    // Stratégie pour les objets maudit
    public class ConjuredItemStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            // diminue de 2 par jour et de 4 par jour après la date d'expiration (limite 0)
            item.Quality = Math.Max(0, item.Quality - (item.SellIn > 0 ? 2 : 4));
            // La date diminue de 1 par jour
            item.SellIn--;
        }
    }
}
