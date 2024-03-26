namespace memorize.core;
public class CardService(IDataRepository dataRepository)
{
    private readonly IDataRepository _dataRepository = dataRepository;

    public IEnumerable<string> GetTopics()
    {
        return _dataRepository.GetTopics();
    }
    public IEnumerable<Card> GetCardsForTopic(string topic)
    {
        return _dataRepository.GetCardsForTopic(topic);
    }
    public void UpdateCard(Card card)
    {
        _dataRepository.UpdateCard(card);
    }
}
