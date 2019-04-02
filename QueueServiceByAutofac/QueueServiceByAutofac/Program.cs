using System;
using Autofac;

namespace QueueServiceByAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PushServive>().As<IPushServive>();
            builder.RegisterType<PopService>().As<IPopService>();
            var container = builder.Build();

            container.Resolve<IPushServive>().Execute();
            container.Resolve<IPopService>().Execute();
            Console.ReadLine();
        }
    }
}