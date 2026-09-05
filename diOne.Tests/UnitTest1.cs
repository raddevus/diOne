using Models;
namespace diOne.Tests;

public class UnitTest1
{
	[Fact]
        public void ExclaimWillWriteCorrectMessageToMessageWriter()
        {
            // Arrange
            var writer = new SpyMessageWriter();

            var sut = new Salutation(writer);

            // Act
            sut.Exclaim();

            // Assert
            Assert.Equal(
                expected: "Hello DI!",
                actual: writer.WrittenMessage);
        }
}
