namespace Day4
{
    public class InputData
    {
        public string NumbersToCall { get; private set; }
        public List<string[]> BingoCards { get; private set; } = new List<string[]>();

        public InputData(string[] fileLines)
        {
            NumbersToCall = fileLines[0];

            int LinesPerBingoCardWithWhitespace = 6;
            
            int NumberOfBingoCards = (fileLines.Length - 1) / LinesPerBingoCardWithWhitespace;
            for (int i = 0; i < NumberOfBingoCards; i++)
            {
                string[] BingoCardData = new string[5];
                for (int j = 1; j < LinesPerBingoCardWithWhitespace; j++)
                {
                    int fileLineIndex = 1 + (j + (i * LinesPerBingoCardWithWhitespace));
                    BingoCardData[j-1] = fileLines[fileLineIndex];
                }
                BingoCards.Add(BingoCardData);
            }
        }
    }
}
