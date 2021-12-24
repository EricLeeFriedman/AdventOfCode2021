// See https://aka.ms/new-console-template for more information

using Day4;

/// <summary>
/// PART 1
/// </summary>

/*
string[] exampleInput = File.ReadAllLines(@"Day4Input.txt");

InputData inputData = new(exampleInput);

NumberCaller numberCaller = new(inputData.NumbersToCall);
List<BingoCard> bingoCards = new(inputData.BingoCards.Count);

for (int i = 0; i < inputData.BingoCards.Count; i++)
{
    bingoCards.Add(new(inputData.BingoCards[i]));
}

int score = 0;
while (true)
{
    int nextNumber = numberCaller.CallNext();

    bool aWinnerIsYou = false;
    for (int i = 0; i < bingoCards.Count; i++)
    {
        aWinnerIsYou = bingoCards[i].MarkNumber(nextNumber);
        if (aWinnerIsYou)
        {
            List<int> unmarkedNumbers = bingoCards[i].GetUnmarkedNumbers();
            score = unmarkedNumbers.Sum(n => n) * nextNumber;
            break;
        }
    }

    if (aWinnerIsYou)
    {
        break;
    }
}

Console.WriteLine(score);
*/

/// <summary>
/// PART 2
/// </summary>
string[] exampleInput = File.ReadAllLines(@"Day4Input.txt");

InputData inputData = new(exampleInput);

NumberCaller numberCaller = new(inputData.NumbersToCall);
List<BingoCard> bingoCards = new(inputData.BingoCards.Count);

for (int i = 0; i < inputData.BingoCards.Count; i++)
{
    bingoCards.Add(new(inputData.BingoCards[i]));
}

while (true)
{
    int nextNumber = numberCaller.CallNext();

    List<int> winningCards = new();
    for (int i = 0; i < bingoCards.Count; i++)
    {
        if (bingoCards[i].MarkNumber(nextNumber))
        {
            winningCards.Add(i);
        }
    }

    int[] sortedCards = winningCards.OrderByDescending(x => x).ToArray();
    foreach (int winningCard in sortedCards)
    {
        bingoCards.RemoveAt(winningCard);
    }

    if (bingoCards.Count == 1)
    {
        break;
    }
}

int score = 0;
while (true)
{
    int nextNumber = numberCaller.CallNext();
    if (bingoCards[0].MarkNumber(nextNumber))
    {
        List<int> unmarkedNumbers = bingoCards[0].GetUnmarkedNumbers();
        score = unmarkedNumbers.Sum(n => n) * nextNumber;
        break;
    }
}

Console.WriteLine(score);