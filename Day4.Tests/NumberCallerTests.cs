using Xunit;

namespace Day4.Tests
{
    public class NumberCallerTests
    {
        [Fact]
        public void InitializedCaller_CallNextReturnsTheFirstEntry()
        {
            // Arrange
            NumberCaller numberCaller = new("50");

            // Act
            int Number = numberCaller.CallNext();

            // Assert
            Assert.Equal(50, Number);
        }

        [Fact]
        public void InitializedCallerWithTwoNumbers_SecondCallNextReturnsTheSecondEntry()
        {
            // Arrange
            NumberCaller numberCaller = new("50,75");

            // Act
            int Number = numberCaller.CallNext();
            Number = numberCaller.CallNext();

            // Assert
            Assert.Equal(75, Number);
        }
    }
}