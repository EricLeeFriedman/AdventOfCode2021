using System;
using Xunit;

namespace Day2.Tests
{
    public class CommandInterpreterTests
    {
        private void CallbackOne()
        {

        }

        [Fact]
        public void RegisterDelegateToForward_Forward5IsReturnedInTuple()
        {
            // Arrange
            ICommandInterpreter CommandInterpreter = new CommandInterpreter();

            // Act
            CommandInterpreter.RegisterCommand("forward", this.CallbackOne);
            Tuple<Delegate, int> CommandAndValue = CommandInterpreter.GetCommandCallbackAndValue("forward 5");

            // Assert
            Assert.Equal(CommandAndValue.Item1, CallbackOne);
        }
    }
}
