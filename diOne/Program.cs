using Models;
using Microsoft.Practices.Unity;
using Edict.Common.DependencyInjection;
using Edict.Common.DependencyInjection.Unity;
using Interfaces;

var container = DependencyInjection.GetUnityContainer(DependencyInjection.GetContainer());
container.RegisterType<IMessageWriter, SpyMessageWriter>();
container.RegisterType<IMessageWriter, ConsoleMessageWriter>("console");
Console.WriteLine("Hello, World!");
Console.WriteLine("It's working!");
ConsoleMessageWriter cmw = new();
cmw.Write("test it out");
IMessageWriter conwriter = container.Resolve<IMessageWriter>("console");
IMessageWriter writer = container.Resolve<IMessageWriter>();
conwriter.Write("simple writer.");
writer.Write("Hello World!");
