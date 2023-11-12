using GildedRoseKata;

namespace GildedRose.Services.States
{
    public class NormalItemState : IItemState
    {
        public void UpdateQuality(Item item)
        {
            // Update logic for a normal item state
            if (item.Quality > 0)
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
