using System;

namespace GildedRoseKata.Domaine
{
    // Stratégie pour les objets billets de concert
    public class BackstagePassStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            // La qualité des billets augmente avec le temps sauf si le concert a eu lieu
            // Augmente de 1 par jour si il y a plus de 10 jours restant -- limite a 50
            // Augmente de 2 entre 6 et 10 jours restant -- limite a 50
            // Augmente de 3 entre 1 et 5 jours restant -- limite a 50
            // la qualité tombe a 0 si le concert a eu lieu
            if (item.SellIn <= 0)
            {
                item.Quality = 0; 
            }
            else if (item.SellIn <= 5)
            {
                item.Quality = Math.Min(50, item.Quality + 3);
            }
            else if (item.SellIn <= 10)
            {
                item.Quality = Math.Min(50, item.Quality + 2);
            }
            else
            {
                item.Quality = Math.Min(50, item.Quality + 1);
            }

            // La date diminue de 1 par jour
            item.SellIn--;
        }
    }
}
