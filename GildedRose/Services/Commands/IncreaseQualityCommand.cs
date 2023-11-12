using GildedRoseKata;

namespace GildedRose.Services.Commands
{
    public class IncreaseQualityCommand : ICommand
    {
        private readonly Item _item;

        public IncreaseQualityCommand(Item item)
        {
            _item = item;
        }

        public void Execute()
        {
            _item.Quality += 1;
        }

        public void Undo()
        {
            _item.Quality -= 1;
        }
    }
}
