namespace GildedRoseKata.Domaine
{
    // Stratégie pour les objets Aged Brie
    public class AgedBrieStrategy : IUpdateStrategy
    {
        public void Update(Item item) {
            // La qualité du brie augmente avec le temps
            // Augmente de 1 par jour. Augmente de 2 après expiration.
            // Limite à 50.
            item.Quality = Math.Min(50, item.Quality + (item.SellIn >  0 ? 1 : 2));
            // La date diminue de 1 par jour
            item.SellIn--;
        }
    }
}
