namespace Day2
{
    public class Submarine
    {
        public int HorizontalPosition { get; private set; } = 0;
        public int Depth { get; private set; } = 0;
        public int Aim { get; private set; } = 0;

        private ICommandInterpreter? _commandInterpreter = null;

        public void SetCommandInterpreter(ICommandInterpreter commandInterpreter)
        {
            _commandInterpreter = commandInterpreter;
        }

        public void IssueCommands(string[] Commands)
        {
           Array.ForEach(Commands, c => HandleCommand(c));
        }

        private void HandleCommand(string Command)
        {
            Tuple<Delegate, int>? CommandAndValue = _commandInterpreter?.GetCommandCallbackAndValue(Command);
            CommandAndValue?.Item1.DynamicInvoke(CommandAndValue.Item2);
        }

        public void MoveForward(int Distance)
        {
            HorizontalPosition += Distance;
        }

        public void MoveForwardWithAim(int Distance)
        {
            HorizontalPosition += Distance;
            Depth += (Aim * Distance);
        }

        public void MoveDown(int Distance)
        {
            Depth += Distance;
        }

        public void MoveDownWithAim(int Distance)
        {
            Aim += Distance;
        }

        public void MoveUp(int Distance)
        {
            Depth -= Distance;
        }

        public void MoveUpWithAim(int Distance)
        {
            Aim -= Distance;
        }
    }
}
