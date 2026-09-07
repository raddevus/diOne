using Interfaces;

public class ConsoleService {
   IMessageWriter Writer;
   public ConsoleService(IMessageWriter writer){
      if (writer == null){ throw new NullReferenceException("no writer");}
      Writer = writer;
   }
   public void WriteOn(string msg){
      Writer.Write(msg);
   }
}
