using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demobuilder
{
    class UserBuilder : IUserBuilder
    {
        String Name { get; set; }
        int Age { get; set; }
        String CCCD { get; set; }
        String Phone { get; set; }
        String Nationality { get; set; }
        String Sex { get; set; }

        public UserBuilder AddName(string name)
        {
            Name = name;
            return this;
        }    

        public UserBuilder AddAge(int age)
        {
            Age = age;
            return this;
        }

        public UserBuilder AddCCCD(string cccd)
        {
            CCCD = cccd;
            return this;
        }

        public UserBuilder AddPhoneNumber(string phone)
        {
            Phone = phone;
            return this;
        }

        public UserBuilder AddNationality(string nationality)
        {
            Nationality = nationality;
            return this;
        }

        public UserBuilder ChooseSex(string sex)
        {
            Sex = sex;
            return this;
        }

        public User Build()
        {
            return new User(Name, Age, CCCD, Phone, Nationality, Sex);
        }
    }
}
