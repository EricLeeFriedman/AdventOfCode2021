using Xunit;

namespace Day4.Tests
{
    public class InputDataTests
    {
        [Fact]
        public void InitializeInputData_ReturnsNumbersToCall()
        {
            // Arrange
            string numbersToCall = "1,5,7,9,13";

            // Act
            InputData inputData = new(new string[] { numbersToCall });

            // Assert
            Assert.Equal(inputData.NumbersToCall, numbersToCall);
        }

        [Fact]
        public void InitializeInputDataWith3BingoCards_ReturnsACountOf3BingoCards()
        {
            // Arrange
            string numbersToCall = "1,5,7,9,13";            
            string dummyBingoCardLine = "1 2 3 4 5";

            // Act
            InputData inputData = new(new string[] { numbersToCall, 
            string.Empty,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,

            string.Empty,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,

            string.Empty,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine,
            dummyBingoCardLine});

            // Assert
            Assert.Equal(3, inputData.BingoCards.Count);            
        }
    }
}
