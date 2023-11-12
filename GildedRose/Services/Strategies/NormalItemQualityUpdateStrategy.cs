using GildedRoseKata;

namespace GildedRose.Services.Strategies
{
    public class NormalItemQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0 && item.Quality <= 50 )
            {
                item.Quality -= 1;

                if (item.SellIn <= 0)
                {
                    item.Quality -= 1;
                }
            }

            item.SellIn -= 1;
        }
    }
}
