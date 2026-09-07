using Models;
using Microsoft.Practices.Unity;
using Edict.Common.DependencyInjection;
using Edict.Common.DependencyInjection.Unity;
using Interfaces;

var container = DependencyInjection.GetContainer();
container.RegisterType<IMessageWriter, SpyMessageWriter>();
Console.WriteLine("Hello, World!");
Console.WriteLine("It's working!");
ConsoleMessageWriter cmw = new();
cmw.Write("test it out");
IMessageWriter writer = container.Resolve<IMessageWriter>();

writer.Write("Hello World!");
