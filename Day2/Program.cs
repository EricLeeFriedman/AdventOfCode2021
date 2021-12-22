using Day2;

string[] commands = File.ReadAllLines(@"Day2Input.txt");

Submarine submarine = new();
ICommandInterpreter commandInterpreter = new CommandInterpreter();
commandInterpreter.RegisterCommand("forward", submarine.MoveForward);
commandInterpreter.RegisterCommand("down", submarine.MoveDown);
commandInterpreter.RegisterCommand("up", submarine.MoveUp);
submarine.SetCommandInterpreter(commandInterpreter);
submarine.IssueCommands(commands);

Console.WriteLine(submarine.HorizontalPosition * submarine.Depth);

Submarine submarine2 = new();
ICommandInterpreter commandInterpreter2 = new CommandInterpreter();
commandInterpreter2.RegisterCommand("forward", submarine2.MoveForwardWithAim);
commandInterpreter2.RegisterCommand("down", submarine2.MoveDownWithAim);
commandInterpreter2.RegisterCommand("up", submarine2.MoveUpWithAim);
submarine2.SetCommandInterpreter(commandInterpreter2);
submarine2.IssueCommands(commands);

Console.WriteLine(submarine2.HorizontalPosition * submarine2.Depth);