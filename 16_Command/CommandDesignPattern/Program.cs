using CommandDesignPattern;
using CommandDesignPattern.ConcreteCommand;
using CommandDesignPattern.IoTDevice;

Invoker invoker = new();
CommandHistory history = new();

CeilingLight ceilingLight = new();
LightOnCommand lightOnCommand = new(ceilingLight);
GarageDoor garageDoor = new();
DoorUpCommand doorUpCommand = new(garageDoor);
Stereo stereo = new();
StereoOnWithCdCommand cdCommand = new(stereo, "ABC", 12);
StereoOffCommand stereoOffCommand = new(stereo);

invoker.SetCommand(lightOnCommand);
invoker.ExecutionCommand();
history.Push(lightOnCommand);
invoker.SetCommand(doorUpCommand);
invoker.ExecutionCommand();
history.Push(doorUpCommand);


invoker.SetCommand(cdCommand);
invoker.ExecutionCommand();
history.Push(cdCommand);
/*invoker.UndoCommand();*/
invoker.SetCommand(stereoOffCommand);
invoker.ExecutionCommand();
history.Push(stereoOffCommand);
/*invoker.UndoCommand();*/

Console.WriteLine();

invoker.UndoCommands();

Console.WriteLine();


List<ICommand> commands = new List<ICommand>();
commands.Add(lightOnCommand);
commands.Add(doorUpCommand);
commands.Add(cdCommand);

MacroCommand macroCommand = new MacroCommand(commands);

invoker.SetCommand(macroCommand);
invoker.ExecutionCommand();




