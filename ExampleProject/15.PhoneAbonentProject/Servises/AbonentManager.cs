using _15.PhoneAbonentProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.PhoneAbonentProject.Servises
{
    internal class AbonentManager
    {
        private List<Subscriber> subscribers;

        public AbonentManager()
        {
            subscribers = new List<Subscriber>();
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            if (subscriber == null)
                throw new ArgumentNullException(nameof(subscriber));

            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(int subscriberId)
        {
            var subscriberToRemove = subscribers.FirstOrDefault(s => s.Id == subscriberId);
            if (subscriberToRemove != null)
            {
                subscribers.Remove(subscriberToRemove);
                Console.WriteLine($"Subscriber with ID {subscriberId} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Subscriber with ID {subscriberId} not found");
            }
        }

        public List<Subscriber> GetSubscribers()
        {
            return subscribers.ToList();
        }

        public void ShowAllSubscribers()
        {
            foreach (var subscriber in subscribers)
            {
                Console.WriteLine(subscriber);
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}