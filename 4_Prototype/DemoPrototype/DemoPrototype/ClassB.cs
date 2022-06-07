using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    public class ClassB : MyClass, ICloneable
    {
        private string address;

        public string Address { get => address; set => address = value; }

        //Tạo ra thực thể mới từ chính thằng đang có sẵn
        public object Clone()
        {
            ClassB newClass = base.Clone() as ClassB;
            newClass.Address = this.address;

            return newClass;
        }

        //Overwrite hàm toString()
        public override string ToString()
        {
            return base.ToString() + " | " + "Address: " + this.address;
        }
    }
}
