namespace AlertPronuncer.Servcies;

public interface IMessagePronuncer
{
    Task SpeakAsync(string message);
}
