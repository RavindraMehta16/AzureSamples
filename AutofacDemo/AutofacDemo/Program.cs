using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using BusinessDomain;

namespace AutofacDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var container = BuildContainer();
            container.Resolve<ISupplyChainFactory>().GetMessage("ASDFas");
            Console.ReadLine();
        
        }

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            //******** individual registration of type
            // builder.RegisterType<SupplyChainA>().As<ISupplyChain>();
            // builder.RegisterType<SupplyChainB>().As<ISupplyChain>();
            // builder.RegisterType<SupplyChainC>().As<ISupplyChain>();


            //********* bulk registration using reflection/assembly for similar types
            builder.RegisterAssemblyTypes(typeof(AbstractSupplyChain).Assembly)
               .Where(t => typeof(SupplyChainA).IsAssignableFrom(t))
               // .Where(t=>t.Name.StartsWith("Supply"))
               .AsSelf()
               .SingleInstance()
               .As<ISupplyChain>();

            builder.RegisterType<SupplyChainFactory>().As<ISupplyChainFactory>();



            

            return builder.Build();
        }
    }
}
