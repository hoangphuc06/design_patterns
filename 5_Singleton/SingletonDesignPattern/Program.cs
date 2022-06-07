using SingletonDesignPattern;

EagerInitialization.GetInstance().DoSomeThing();
LazyInitialization.GetInstance().DoSomeThing();
ThreadSafeSingleton.GetInstance().DoSomeThing();
BillPughImplementation.GetInstance().DoSomeThing();


Console.ReadLine();

EagerInitialization.GetInstance().DoSomeThing();
LazyInitialization.GetInstance().DoSomeThing();
ThreadSafeSingleton.GetInstance().DoSomeThing();
BillPughImplementation.GetInstance().DoSomeThing();
