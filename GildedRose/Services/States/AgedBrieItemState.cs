using GildedRoseKata;

namespace GildedRose.Services.States
{
    public class AgedBrieItemState : IItemState
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }

            item.SellIn -= 1;
        }
    }
}
