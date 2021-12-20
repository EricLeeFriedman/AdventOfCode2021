string[] lines = File.ReadAllLines(@"Day1Input.txt");
int[] input = Array.ConvertAll(lines, int.Parse);

Console.WriteLine("Number of Decreases: {0}", Day1.SonarSweeper.GetDepthIncreases(input));
Console.WriteLine("Number of Grouped Decreases: {0}", Day1.SonarSweeper.GetGroupedDepthIncreases(input));