using System;

namespace demobuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new User("Hoang"
                                , 20
                                , "215526840"
                                , "0384237411"
                                , "Vietnam"
                                , "Nam");

            var itemBuilder = new UserBuilder()
                                  .AddName("Hoang")
                                  .AddAge(20)
                                  .AddCCCD("215526840")
                                  .AddPhoneNumber("0384237411")
                                  .AddNationality("Vietnam")
                                  .ChooseSex("Nam")
                                  .Build();


            Console.WriteLine(item.ToString());
            Console.WriteLine("---------");
            Console.WriteLine(itemBuilder.ToString());
        }
    }
}
