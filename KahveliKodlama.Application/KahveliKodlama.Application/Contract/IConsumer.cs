namespace KahveliKodlama.Application.Contract;
public interface IConsumer<T>
{
    void HandleEventAsync(T eventMessage);


}
