namespace Day1
{
    internal class SonarSweeper
    {
        static public int GetDepthIncreases(int[] ScanDepths)
        {
            if (ScanDepths.Length < 2)
            {
                return 0;
            }

            int NumDepthIncreases = 0;
            int PreviousDepth = ScanDepths[0];
            for (int i = 1; i < ScanDepths.Length; i++)
            {
                if (PreviousDepth < ScanDepths[i])
                {
                    NumDepthIncreases++;
                }
                PreviousDepth = ScanDepths[i];
            }

            return NumDepthIncreases;
        }

        static public int GetGroupedDepthIncreases(int[] ScanDepths)
        {
            if (ScanDepths.Length < 4)
            {
                return 0;
            }

            int NumDepthIncreases = 0;

            int PreviousDepth = GetTotalDepthOfThreeScansFromIndex(ScanDepths, 0);

            for (int i = 1; i < ScanDepths.Length - 2; i++)
            {
                int CurrentDepth = GetTotalDepthOfThreeScansFromIndex(ScanDepths, i);
                if (PreviousDepth < CurrentDepth)
                {
                    NumDepthIncreases++;
                }
                PreviousDepth = CurrentDepth;
            }

            return NumDepthIncreases;
        }
        
        static private int GetTotalDepthOfThreeScansFromIndex(int[] ScanDepths, int StartingScanIndex)
        {
            return ScanDepths.Take(new Range(StartingScanIndex, StartingScanIndex + 3)).Sum(x => x);
        }
    }
}
