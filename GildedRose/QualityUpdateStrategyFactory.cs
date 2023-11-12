using GildedRose.Services.Strategies;
using GildedRoseKata;

namespace GildedRose
{
    public static class QualityUpdateStrategyFactory
    {
        public static IQualityUpdateStrategy CreateQualityUpdateStrategy(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieQualityUpdateStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassQualityUpdateStrategy();
                case "Conjured":
                    return new ConjuredItemQualityUpdateStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItemQualityUpdateStrategy();
                default:
                    return new NormalItemQualityUpdateStrategy();
            }
        }
    }

}
