using Contracts;
using Moq;
using Service;

namespace TestService
{
    public class CalculatorTests
    {
        private Mock<ILogger> _logger;

        public CalculatorTests()
        {
            _logger = new Mock<ILogger>();
        }
        [Fact]
        public void WhenAddingTwoNumbers_ThenResultIsCorrect()
        {
            // Arrange
            _logger.As<ILogger>().Setup(x => x.Log(It.IsAny<string>()));
            var calculator = new Calculator(_logger.Object);
            // Act
            var result = calculator.Add(1, 2);
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void WhenAddingTwoNumbers_ThenLogIsCalled()
        {
            // Arrange
            _logger.As<ILogger>().Setup(x => x.Log(It.IsAny<string>()));
            var calculator = new Calculator(_logger.Object);
            // Act
            var result = calculator.Add(1, 2);
            // Assert
            _logger.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }
    }