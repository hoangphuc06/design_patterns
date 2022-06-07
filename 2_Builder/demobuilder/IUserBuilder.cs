using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demobuilder
{
    interface IUserBuilder
    {
        UserBuilder AddName(string name);
        UserBuilder AddAge(int age);
        UserBuilder AddCCCD(string cccd);
        UserBuilder AddPhoneNumber(string phone);
        UserBuilder AddNationality(string nationality);
        UserBuilder ChooseSex(string sex);

        User Build();
    }
}
