using InterpreterDesignPattern;
using InterpreterDesignPattern.ConcreteExpression;

Console.Title = "Interpreter Design Pattern Example";

List<Context> listAircrafts = new ();
List<IExpression> listExpressions = new ();

listAircrafts.Add(new Context("A330"));
listAircrafts.Add(new Context("A330F"));
listAircrafts.Add(new Context("B777"));
listAircrafts.Add(new Context("B777F"));
listAircrafts.Add(new Context("TheCode"));

listExpressions.Add(new CheckExpression());
listExpressions.Add(new BrandExpression());
listExpressions.Add(new ModelExpression());
listExpressions.Add(new TypeExpression());

for (int ac_index = 0; ac_index < listAircrafts.Count; ac_index++)
{
    for (int exp_index = 0; exp_index < listExpressions.Count; exp_index++)
    {
        listExpressions[exp_index].Evaluate(listAircrafts[ac_index]);
    }
    Console.WriteLine("-----------------------------------");
}
Console.ReadLine();