using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Id = "1";
            myClass.Name = "MyClass";
            Console.WriteLine(myClass.ToString());

            ClassA classA = new ClassA();
            classA.Id = "2";
            classA.Name = "ClassA";
            classA.Info = "InfoA";
            Console.WriteLine(classA.ToString());

            ClassB classB = new ClassB();
            classB.Id = "3";
            classB.Name = "ClassB";
            classB.Address = "AddressB";
            Console.WriteLine(classB.ToString());

            Console.ReadKey();
        }
    }
}
