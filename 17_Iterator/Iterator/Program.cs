using Iterator.ConcreteAggregate;
using System;

namespace Iterator
{
    class Client
    {
        static void Main(string[] args)
        {
            Aggregate<int> aggregate = new Aggregate<int>();
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                aggregate[i] = i;
            }

            IIterator<int> iterator = aggregate.CreateIterator();
            Console.WriteLine(iterator.CurrentItem());
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}