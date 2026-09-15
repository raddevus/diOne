using Interfaces;

namespace Models;

public class SpyMessageWriter : IMessageWriter{

	public string WrittenMessage { get; private set; }
	public int MessageCounter{get;private set;}

	public void Write(string msg){
		WrittenMessage += msg;
		MessageCounter++;
		Console.WriteLine($"via Spy: {msg}");
	}
}	
