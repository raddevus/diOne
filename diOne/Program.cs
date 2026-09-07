using Models;
using Microsoft.Practices.Unity;
using Edict.Common.DependencyInjection;
using Edict.Common.DependencyInjection.Unity;
using Interfaces;

var container = DependencyInjection.GetUnityContainer(DependencyInjection.GetContainer());
container.RegisterType<IMessageWriter, SpyMessageWriter>("spy");
container.RegisterType<IMessageWriter, ConsoleMessageWriter>();
ConsoleMessageWriter cmw = new();
cmw.Write("test it out");
IMessageWriter spywriter = container.Resolve<IMessageWriter>("spy");
IMessageWriter writer = container.Resolve<IMessageWriter>();
spywriter.Write("I spy!");
writer.Write("Hello World!");

//ConsoleService consvc = new (
