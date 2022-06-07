using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    public class MyClass : ICloneable
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        //Tạo ra thực thể mới từ chính thằng đang có sẵn
        public object Clone()
        {
            return new MyClass() { Id = this.id, Name = this.Name };
        }

        //Overwrite hàm toString()
        public override string ToString()
        {
            return "ID: " + this.id + " | " + "Name: " + this.name;
        }
    }
}
