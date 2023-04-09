using AL.Serivces;
using AL.Serivces.Interfaces;
using Autofac;

namespace AL
{
    public class Runner
    {
        private bool _run = true;

        public void Main()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);

            using (var container = builder.Build()) 
            {
                Console.WriteLine("Hello");
                while (_run)
                {
                    string? input = Console.ReadLine();
                    if (input == "x")
                    {
                        _run = false;
                    }
                    else 
                    { 
                        var parser = container.ResolveOptional<IInputParser>();
                        parser?.Parse(input);
                    }
                }
            }
        }

        private void RegisterTypes(ContainerBuilder builder)
        {
            builder
                .RegisterType<InputParser>()
                .As<IInputParser>()
                .InstancePerLifetimeScope();

        }
    }
}
