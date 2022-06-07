using Iterator.ConcreteAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.ConcreteIterator
{
    public class Iterator<T> : IIterator<T>
    {
        private Aggregate<T> aggregate;
        private int current;
        private Aggregate<T> aggregate1;

        public Iterator(Aggregate<T> aggregate)
        {
            this.aggregate = aggregate;
            this.First();
        }

        public T CurrentItem() => this.aggregate[this.current];
        public T First()
        {
            this.current = 0;
            return this.aggregate[this.current];
        }
        public bool IsDone() => this.current + 1 == this.aggregate.Count;
        public T Next() => this.aggregate[++this.current];
    }
}
