using Xunit;

namespace Day2.Tests
{
    public class SubmarineTests
    {
        [Fact]
        public void NoCommands_HorizontalPositionIsZero()
        {
            // Arrange
            Submarine submarine = new();

            // Act

            // Assert
            Assert.Equal(0, submarine.HorizontalPosition);
        }

        [Fact]
        public void NoCommands_DepthIsZero()
        {
            // Arrange
            Submarine submarine = new();

            // Act

            // Assert
            Assert.Equal(0, submarine.Depth);
        }

        [Fact]
        public void OneForwardCommandOfFive_HorizontalPositionIsFive()
        {
            // Arrange
            Submarine submarine = new();
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            commandInterpreter.RegisterCommand("forward", submarine.MoveForward);
            submarine.SetCommandInterpreter(commandInterpreter);

            // Act
            submarine.IssueCommands(new string[] { "forward 5" });

            // Assert
            Assert.Equal(5, submarine.HorizontalPosition);
        }

        [Fact]
        public void OneDownCommandOfFive_DepthIsFive()
        {
            // Arrange
            Submarine submarine = new();
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            commandInterpreter.RegisterCommand("down", submarine.MoveDown);
            submarine.SetCommandInterpreter(commandInterpreter);

            // Act
            submarine.IssueCommands(new string[] { "down 5" });

            // Assert
            Assert.Equal(5, submarine.Depth);
        }

        [Fact]
        public void OneDownCommandOfFive_OneUpCommandOfThree_DepthIsTwo()
        {
            // Arrange
            Submarine submarine = new();
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            commandInterpreter.RegisterCommand("down", submarine.MoveDown);
            commandInterpreter.RegisterCommand("up", submarine.MoveUp);
            submarine.SetCommandInterpreter(commandInterpreter);

            // Act
            submarine.IssueCommands(new string[] { "down 5", "up 3" });

            // Assert
            Assert.Equal(2, submarine.Depth);
        }

        [Fact]
        public void TestInput_AnswerIs150()
        {
            // Arrange
            Submarine submarine = new();
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            commandInterpreter.RegisterCommand("forward", submarine.MoveForward);
            commandInterpreter.RegisterCommand("down", submarine.MoveDown);
            commandInterpreter.RegisterCommand("up", submarine.MoveUp);
            submarine.SetCommandInterpreter(commandInterpreter);

            // Act
            submarine.IssueCommands(new string[] { "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2" });

            // Assert
            Assert.Equal(150, submarine.Depth * submarine.HorizontalPosition);
            
        }

        [Fact]
        public void TestInputWithAim_AnswerIs900()
        {
            // Arrange
            Submarine submarine = new();
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            commandInterpreter.RegisterCommand("forward", submarine.MoveForwardWithAim);
            commandInterpreter.RegisterCommand("down", submarine.MoveDownWithAim);
            commandInterpreter.RegisterCommand("up", submarine.MoveUpWithAim);
            submarine.SetCommandInterpreter(commandInterpreter);

            // Act
            submarine.IssueCommands(new string[] { "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2" });

            // Assert
            Assert.Equal(900, submarine.Depth * submarine.HorizontalPosition);
        }
    }
}