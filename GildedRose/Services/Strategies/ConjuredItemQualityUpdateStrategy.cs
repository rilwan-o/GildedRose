using GildedRoseKata;

namespace GildedRose.Services.Strategies
{
    public class ConjuredItemQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality >= 0)
            {
              item.Quality -= 2;

              if (item.Quality < 0) item.Quality = 0;
            }


            item.SellIn -= 1;
        }
    }
}
