namespace Day2
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private Dictionary<string, Delegate> _commands = new Dictionary<string,Delegate>();

        public Tuple<Delegate, int> GetCommandCallbackAndValue(string command)
        {
            int spaceIndex = command.IndexOf(' ');
            string commandLookup = command.Substring(0, spaceIndex);
            int commandValue = int.Parse(command.Substring(spaceIndex + 1));
            return new Tuple<Delegate, int>(_commands[commandLookup], commandValue);
        }

        public void RegisterCommand(string name, Delegate callback)
        {
            _commands.Add(name, callback);            
        }
    }
}
