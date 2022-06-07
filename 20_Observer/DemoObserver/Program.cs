using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver
{
    public interface IPublisher
    {
        void Import();
        void AddToLoyalCustomer(ISubscriber subscriber);
        void Notify();
    }
    public interface ISubscriber
    {
        void ReceiveNotify();
    }
    public class PublisherA : IPublisher
    {
        private bool isImport = false;

        public List<ISubscriber> subscribers = new List<ISubscriber>();

        public bool IsImport {
            get => isImport;
            set
            {
                isImport = value;
                Notify();
            }
        }

        public void AddToLoyalCustomer(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Import()
        {
            Console.WriteLine("Publish A just imported goods");
            IsImport = true;
        }

        public void Notify()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.ReceiveNotify();
            }    
        }
    }
    public class SubscriberA : ISubscriber
    {
        public string Name;
        public SubscriberA(string name)
        {
            Name = name;
        }
        public void ReceiveNotify()
        {
            Console.WriteLine($"{Name}: I just received notity");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PublisherA publisher = new PublisherA();

            publisher.AddToLoyalCustomer(new SubscriberA("Phuc"));
            publisher.AddToLoyalCustomer(new SubscriberA("Hung"));
            publisher.AddToLoyalCustomer(new SubscriberA("Hoang"));

            publisher.Import();

            Console.ReadKey();


        }
    }
}
