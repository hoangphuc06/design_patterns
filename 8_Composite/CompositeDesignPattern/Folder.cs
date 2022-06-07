using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Folder : IComponent
    {
        public string Name { get; set; }

        readonly List<IComponent> components = new();
        public Folder(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            components.Remove(component);
        }

        public void RightClick()
        {
            Console.WriteLine("{0} was clicked and it could be rename or delete now", Name);
        }

        public void Rename(string newName)
        {
            
            Name = newName;
            Console.WriteLine("Folder was renamed: {0}", Name );
        }

        public void GetComponents()
        {
            Console.WriteLine("Children of {0} are: ", Name);
            foreach(var component in components)
            {
                Console.WriteLine(component.Name);
            }
        }

        public void Delete()
        {
            foreach (var component in components)
            {
                component.Delete();
            }
            Console.WriteLine("{0} was removed", Name);
        }

        public int GetSize()
        {
            var totalSize = 0;
            foreach (var component in components)
            {
                totalSize += component.GetSize();
            }
            Console.WriteLine("Size of foler {0} is {1}", Name, totalSize);
            return totalSize;
        }
    }
}
