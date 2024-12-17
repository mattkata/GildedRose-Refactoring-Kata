using System;

namespace GildedRoseKata.Domaine
{
    // Stratégie pour les objets basique
    public class BasiqueItemStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            // La qualité diminue de 1; si la date d'expiration est dépassée, diminue de 2.
            // Ne descend pas en dessous de 0
            item.Quality = Math.Max(0, item.Quality - (item.SellIn > 0 ? 1 : 2));
            // La date diminue de 1 par jour
            item.SellIn--;
        }

    }
}
