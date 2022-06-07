using System;
using System.Threading;
using ChatRoom;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatRoom room = new ConcreteChatRoom();
            User bob = new User(room, "Bob");
            Thread.Sleep(1000);
            User alice = new User(room, "Alice");
            Thread.Sleep(1000);
            User charlie = new User(room, "Charlie");
            Console.WriteLine("===========================");

            bob.SendMessage("Hello everyone !");
            Thread.Sleep(1000);
            alice.SendMessage("Hello Bob");
            Thread.Sleep(1500);
            charlie.SendMessage("How are you Bob ?");
            Thread.Sleep(2000);
            bob.SendMessage("I'm fine, thanks");

            Console.WriteLine("===========================");
            Thread.Sleep(1000);
            bob.LeaveRoom();
        }
    }
}