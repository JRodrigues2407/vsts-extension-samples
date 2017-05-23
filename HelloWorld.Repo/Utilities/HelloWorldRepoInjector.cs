using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace HelloWorld.Repo.Utilities
{
    public class HelloWorldRepoInjector
    {
        public static void LoadTypes(Container container)
        {
            container.Register<IHelloWorldRepo, HelloWorldRepo>(Lifestyle.Scoped);
        }
    }
}
