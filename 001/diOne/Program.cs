using Models;
using Unity;
//using Edict.Common.DependencyInjection;
//using Edict.Common.DependencyInjection.Unity;
using Interfaces;

IUnityContainer container = new UnityContainer();
container.RegisterType<IMessageWriter, SpyMessageWriter>("spy");
container.RegisterType<IMessageWriter, ConsoleMessageWriter>("con");
container.RegisterType<IMessageWriter, ConsoleMessageWriter>();
//container.RegisterType<IWriterService, ConsoleService>();
var bcs = container.Resolve<BroadcastService>();
ConsoleMessageWriter cmw = new();
cmw.Write("test it out");
IMessageWriter spywriter = container.Resolve<IMessageWriter>("spy");
IMessageWriter writer = container.Resolve<IMessageWriter>();
spywriter.Write("I spy!");
writer.Write("Hello World!");
Console.WriteLine("Broadcast...");
bcs.Broadcast("This 1 goes everywhere.");

