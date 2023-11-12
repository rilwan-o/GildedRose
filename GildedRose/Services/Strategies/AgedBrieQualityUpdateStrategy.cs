using GildedRoseKata;

namespace GildedRose.Services.Strategies
{
    public class AgedBrieQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;

                if (item.Quality < 50 && item.SellIn <= 10)
                {
                    item.Quality += 1;
                }

                if (item.Quality < 50 && item.SellIn <= 5)
                {
                    item.Quality += 1;
                }
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }

            item.SellIn -= 1;
        }
    }
}
