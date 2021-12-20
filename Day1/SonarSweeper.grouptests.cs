using Xunit;

namespace Day1
{
    public class SonarSweeperGroupTests
    {
        [Fact]
        public void NoScans_NoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetGroupedDepthIncreases(new int[] { });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void OneScan_NoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetGroupedDepthIncreases(new int[] { 1 });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void TwoScans_NoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetGroupedDepthIncreases(new int[] { 1, 2 });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void ThreeScans_NoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetGroupedDepthIncreases(new int[] { 1, 2, 3 });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void FourScans_SecondGroupDeeper_OneDepthIncrease()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetGroupedDepthIncreases(new int[] { 1, 2, 3, 4 });

            // Assert
            Assert.Equal(1, DepthIncreases);
        }

        [Fact]
        public void TestInput_FiveDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetGroupedDepthIncreases(new int[] { 199,
                    200,
                    208,
                    210,
                    200,
                    207,
                    240,
                    269,
                    260,
                    263 });

            // Assert
            Assert.Equal(5, DepthIncreases);
        }
    }
}
