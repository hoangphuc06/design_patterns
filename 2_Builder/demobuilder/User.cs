using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demobuilder
{
    class User
    {
        String Name { get; set; }
        int Age  { get; set; }
        String CCCD { get; set; }
        String Phone { get; set; }
        String Nationality { get; set; }
        String Sex { get; set; }

        public User(string name, int age, string cccd, string phone, string nationality, string sex)
        {
            Name = name;
            Age = age;
            CCCD = cccd;
            Phone = phone;
            Nationality = nationality;
            Sex = sex;
        }

        public override string ToString()
        {
            var content = "";
            content += $"Ho va ten:             \t {Name}\n";
            content += $"Tuoi:                  \t {Age}\n";
            content += $"Can cuoc cong dan:     \t {CCCD}\n";
            content += $"So dien thoai:         \t {Phone}\n";
            content += $"Quoc tich:             \t {Nationality}\n";
            content += $"Gioi tinh:             \t {Sex}";
            return content;
        }
    }
}
