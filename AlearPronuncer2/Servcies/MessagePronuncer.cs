
namespace AlertPronuncer.Servcies;


public class MessagePronuncer : IMessagePronuncer
{
    public async Task SpeakAsync(string message)
    {
        await TextToSpeech.SpeakAsync(message);
    }
}
