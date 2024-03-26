namespace memorize.tests;

using memorize.core;

internal class TestRepository : IDataRepository
{
    public IEnumerable<string> GetTopics()
    {
        return new List<string> { "topic1", "topic2" };
    }

    public IEnumerable<Card> GetCardsForTopic(string topic)
    {
        return new List<Card>
        {
            new Card { Question = "question1", Answer = "answer1" },
            new Card { Question = "question2", Answer = "answer2" }
        };
    }

    public void UpdateCard(Card card)
    {
        throw new NotImplementedException();
    }

}
