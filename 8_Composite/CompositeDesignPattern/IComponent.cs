using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public interface IComponent
    {
        public string Name { get; set; }
        void RightClick();
        void Rename(string newName);

        int GetSize();
        void Delete();
    }
}
