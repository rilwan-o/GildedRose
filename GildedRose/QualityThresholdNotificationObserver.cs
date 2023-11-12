using GildedRose.Services.Decorators;
using GildedRoseKata;
using System;

namespace GildedRose
{
    public class QualityThresholdNotificationObserver : IItemDecorator
    {
        public void Decorate(Item item)
        {
            // Notify or take action if quality reaches a certain threshold
            if (item.Quality == 0)
            {
                Console.WriteLine($"Item {item.Name} has reached quality level 0. Sending notification...");

                // Placeholder for custom notification logic
                SendNotification(item);
            }
        }

        private void SendNotification(Item item)
        {
            // Placeholder for actual notification logic
            Console.WriteLine($"Notification sent for {item.Name} at quality level 0.");
        }
    }
}
