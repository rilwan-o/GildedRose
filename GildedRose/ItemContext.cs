using GildedRose.Services.Strategies;
using GildedRoseKata;

namespace GildedRose
{
    public class ItemContext
    {
        private readonly Item _item;
        private readonly IQualityUpdateStrategy _qualityUpdateStrategy;

        public ItemContext(Item item)
        {
            _item = item;
            _qualityUpdateStrategy = QualityUpdateStrategyFactory.CreateQualityUpdateStrategy(item);
        }

        public void UpdateQuality()
        {
            _qualityUpdateStrategy.UpdateQuality(_item);
        }
    }
}
