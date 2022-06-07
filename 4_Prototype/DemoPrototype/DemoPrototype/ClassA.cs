using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    public class ClassA : MyClass, ICloneable
    {
        private string info;

        public string Info { get => info; set => info = value; }

        //Tạo ra thực thể mới từ chính thằng đang có sẵn
        public object Clone()
        {
            ClassA newClass = base.Clone() as ClassA;
            newClass.Info = this.info;
            return newClass;
        }

        //Overwrite hàm toString()
        public override string ToString()
        {
            return base.ToString() + " | " + "Info: " + this.info; 
        }
    }
}
