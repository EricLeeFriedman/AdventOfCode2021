namespace Day4
{
    public class BingoCard
    {
        private List<int[]> rows = new(5);

        private Dictionary<int,int> markedRows = new();
        private Dictionary<int,int> markedColumns = new();
        private List<(int, int)> markedNumbers = new();

        public BingoCard(string[] cardInput)
        {
            if (cardInput.Length != 5)
            {
                throw new ArgumentException("Expecting exactly 5 rows of data");
            }

            for (int i = 0; i < cardInput.Length; i++)
            {
                string row = cardInput[i].Trim();
                string[] rowNumbers = row.Split(new char[] { ' ', '\t' }).Where(number => !string.IsNullOrEmpty(number)).ToArray();
                if (rowNumbers.Length != 5)
                {
                    throw new ArgumentException("Row in card input doesn't have exactly 5 numbers");
                }

                rows.Add(Array.ConvertAll(rowNumbers, int.Parse));
            }
        }

        public bool MarkNumber(int Number)
        {
            int rowIndex = -1;
            int columnIndex = -1;
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Contains(Number))
                {
                    rowIndex = i;
                    columnIndex = Array.IndexOf(rows[i], Number);
                    break;
                }
            }

            if (rowIndex != -1)
            {
                markedNumbers.Add(new (rowIndex, columnIndex));
                markedRows[rowIndex] = markedRows.GetValueOrDefault(rowIndex) + 1;
                markedColumns[columnIndex] = markedColumns.GetValueOrDefault(columnIndex) + 1;

                if (markedRows[rowIndex] == 5 ||
                    markedColumns[columnIndex] == 5)
                {
                    return true;
                }
            }
            return false;
        }

        public List<int> GetUnmarkedNumbers()
        {
            List<int> unmarkedNumbers = new();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j< 5; j++)
                {
                    if (!markedNumbers.Contains(new(i, j)))
                    {
                        unmarkedNumbers.Add(rows[i][j]);
                    }
                }
            }
            return unmarkedNumbers;
        }
    }
}
