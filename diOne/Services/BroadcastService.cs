using Interfaces;

public class BroadcastService
{
    private readonly IEnumerable<IMessageWriter> _writers;

    // Unity injects ALL registered implementations ( named)
    public BroadcastService(IMessageWriter[] writers)
    {
         // Discovered that only the named ones will get in here
         // Unless you name the RegisteredType it will not show up 
        _writers = writers;
        Console.WriteLine($"writer count: {writers.Length}");
    }

    public void Broadcast(string text)
    {
        foreach (var writer in _writers)
        {
            writer.Write(text);
        }
    }
}
