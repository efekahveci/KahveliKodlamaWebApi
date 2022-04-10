namespace KahveliKodlama.Application.Contract;
public partial interface IEventPublisher
{
    void PublishAsync<TEvent>(TEvent @event);


}
