namespace Day2
{
    public interface ICommandInterpreter
    {
        void RegisterCommand(string name, Delegate callback);

        Tuple<Delegate, int> GetCommandCallbackAndValue(string command);
    }
}
