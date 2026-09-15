using Interfaces;

namespace Models;
public class Salutation
{
private readonly IMessageWriter writer;

	public Salutation(IMessageWriter writer)
	{
	    if (writer == null)
		throw new ArgumentNullException("writer");

	    this.writer = writer;
	}

   public void Write (string msg){
      writer.Write($"Salute! {msg}");
      }

	public void Exclaim()
	{
	    this.writer.Write("Hello DI!");
	}
}
