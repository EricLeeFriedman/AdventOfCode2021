namespace Day4
{
    public class NumberCaller
    {
        private int NumberIndex = 0;
        private IEnumerable<int>? Numbers = null;

        public NumberCaller(string NumbersInput)
        {
            string[] NumberArray = NumbersInput.Split(',');
            Numbers = NumberArray.Select(number => int.Parse(number));
        }

        public int CallNext()
        {
            return Numbers?.ElementAt(NumberIndex++) ?? throw new Exception("You called next before initializing ya dope");
        }
    }
}
