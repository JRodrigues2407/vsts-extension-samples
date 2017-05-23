using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Services;
using HelloWorld.Services.Utilities;
using HelloWorld.Utilities;
using SimpleInjector;
using SimpleInjector.Extensions.LifetimeScoping;

namespace HelloWorld
{
    public class HelloWorld
    {
        private static IHelloWorldService _helloWorldService;

        private static Container _container;

        static void Main(string[] args)
        {
            _container = new Container();
            _container.Options.DefaultScopedLifestyle = new LifetimeScopeLifestyle();
            _container.Register<IHelloWorldService, HelloWorldService>(Lifestyle.Scoped);
            SimpleInjectorAccessor.RegisterContainer(_container);

            SimpleInjectorAccessor.Load(HelloWorldServiceInjector.LoadTypes);

            _container.Verify();

            using (_container.BeginLifetimeScope())
            {
                try
                {
                    var isCodingExercise = Convert.ToBoolean(ConfigurationSettings.AppSettings["isCodingExercise"]);
                    _helloWorldService = _container.GetInstance<IHelloWorldService>();

                    var result = _helloWorldService.GetStartMessage(isCodingExercise);

                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred.");
                    Console.ReadLine();
                }
            }
        }
    }
}
