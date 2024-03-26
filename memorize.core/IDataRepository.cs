namespace memorize.core;

public interface IDataRepository
{
    IEnumerable<string> GetTopics();
    IEnumerable<Card> GetCardsForTopic(string topic);
    void UpdateCard(Card card);
}