using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class MyFile : IComponent
    {
        public string Name { get; set; }
        public MyFile(string name)
        {
            this.Name = name;
        }

        public void Rename(string newName)
        {
            Name = newName;
            Console.WriteLine("File was renamed: {0}", Name);

        }

        public void RightClick()
        {
            Console.WriteLine("{0} was clicked and it could be rename or delete now", Name);
        }

        public void Delete()
        {
            Console.WriteLine("{0} was removed", Name);
        }

        public int GetSize()
        {
            var rand = new Random();
            var size = rand.Next(0, 100);
            Console.WriteLine("Size of {0} is: {1}", Name, size);
            return size;
        }
    }
}
