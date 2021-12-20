using Xunit;

namespace Day1
{
    public class SonarSweeperTests
    {
        [Fact]
        public void NoScans_NoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void OneScan_NoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 1 });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }
        
        [Fact]
        public void TwoScans_SecondScanLower_OneDepthIncrease()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 1, 2 });

            // Assert
            Assert.Equal(1, DepthIncreases);
        }

        [Fact]
        public void TwoScans_SecondScanHigher_ZeroDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 2, 1 });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void ThreeScans_AllScansLower_TwoDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 1, 2, 3 });

            // Assert
            Assert.Equal(2, DepthIncreases);
        }

        [Fact]
        public void ThreeScans_MiddleScanHighest_OneDepthIncrease()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 1, 3, 2 });

            // Assert
            Assert.Equal(1, DepthIncreases);
        }

        [Fact]
        public void ThreeScans_AllScansHigher_ZeroDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 3, 2, 1 });

            // Assert
            Assert.Equal(0, DepthIncreases);
        }

        [Fact]
        public void TestInput_SevenDepthIncreases()
        {
            // Arrange

            // Act
            int DepthIncreases = SonarSweeper.GetDepthIncreases(new int[] { 199,
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
            Assert.Equal(7, DepthIncreases);
        }
    }
}
