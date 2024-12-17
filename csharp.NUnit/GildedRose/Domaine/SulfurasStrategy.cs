namespace GildedRoseKata.Domaine
{
    // Stratégie pour les objets Sulfuras
    public class SulfurasStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            // rien à mettre a jour; la qualité et le délai d'expiration reste constant
        }
    }
}
