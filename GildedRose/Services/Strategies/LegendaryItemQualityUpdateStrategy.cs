using GildedRoseKata;

namespace GildedRose.Services.Strategies
{
    public class LegendaryItemQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            // Legendary items do not change
        }
    }
}
