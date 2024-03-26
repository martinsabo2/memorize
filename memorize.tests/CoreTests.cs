using memorize.core;

namespace memorize.tests;
public class CoreTests
{
    [Fact]
    public void GetTopics_ReturnsTopics()
    {
        // Arrange
        var repository = new TestRepository();
        var service = new CardService(repository);

        // Act
        var topics = service.GetTopics();

        // Assert
        Assert.Equal(2, topics.Count());
    }

    [Fact]
    public void GetCardsForTopic_ReturnsCards()
    {
        // Arrange
        var repository = new TestRepository();
        var service = new CardService(repository);

        // Act
        var cards = service.GetCardsForTopic("topic1");

        // Assert
        Assert.Equal(2, cards.Count());
    }

    [Fact]
    public void UpdateCard_ThrowsNotImplementedException()
    {
        // Arrange
        var repository = new TestRepository();
        var service = new CardService(repository);

        // Act & Assert
        Assert.Throws<NotImplementedException>(() => service.UpdateCard(new Card()));
    }
}
