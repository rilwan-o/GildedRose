using GildedRose.Services.States;
using GildedRoseKata;

namespace GildedRose
{
    public class ItemStateContext
    {
        private readonly Item _item;
        private IItemState _currentState;

        public ItemStateContext(Item item)
        {
            _item = item;
            InitializeState();
        }

        private void InitializeState()
        {
            switch (_item.Name)
            {
                case "Aged Brie":
                    TransitionToState(new AgedBrieItemState());
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    TransitionToState(new BackstagePassItemState());
                    break;
                default:
                    TransitionToState(new NormalItemState());
                    break;
            }
        }

        public void TransitionToState(IItemState newState)
        {
            _currentState = newState;
        }

        public void UpdateQuality()
        {
            _currentState.UpdateQuality(_item);
        }
    }
}
