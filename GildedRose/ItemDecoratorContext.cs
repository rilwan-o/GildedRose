using GildedRose.Services.Decorators;
using GildedRoseKata;
using System.Collections.Generic;

namespace GildedRose
{
    public class ItemDecoratorContext
    {
        private readonly Item _item;
        private readonly List<IItemDecorator> _decorators = new List<IItemDecorator>();

        public ItemDecoratorContext(Item item)
        {
            _item = item;
        }

        public void AddDecorator(IItemDecorator decorator)
        {
            _decorators.Add(decorator);
        }

        public void ApplyDecorators()
        {
            foreach (var decorator in _decorators)
            {
                decorator.Decorate(_item);
            }
        }
    }
}
