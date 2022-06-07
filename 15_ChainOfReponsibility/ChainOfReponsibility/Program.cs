using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility.Conceptual
{
    // Giao diện Handler khai báo phương thức để tạo chuỗi các trình 
    // xử lý. Nó cũng khai báo một phương thức để xử lý yêu cầu.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }

    // Hành vi mặc định cho chuỗi có thể được thực hiện
    // bên trong một lớp xử lý cơ sở.
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Việc trả lại một trình xử lý ở đây sẽ cho phép chúng ta
            // liên kết các trình xử lý theo cách thuận tiện như sau:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        // Client làm việc với một trình xử lý duy nhất. Trong hầu hết các trường
        // hợp, nó thậm chí không biết rằng trình xử lý là một phần của chuỗi.
        public static void ClientCode(AbstractHandler handler)
        {
            var listfood = new List<string> { "Nut", "Banana", "Cup of coffee" };
            foreach (var food in listfood)
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Phần khác của client xây dựng chuỗi thực tế.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // Client có thể gửi yêu cầu tới bất kỳ trình xử lý nào, 
            // không chỉ trình xử lý đầu tiên trong chuỗi.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }
}