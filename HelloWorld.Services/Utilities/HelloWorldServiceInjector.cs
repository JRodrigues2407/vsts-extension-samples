using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Repo.Utilities;
using SimpleInjector;

namespace HelloWorld.Services.Utilities
{
    public class HelloWorldServiceInjector
    {
        public static void LoadTypes(Container container)
        {
            HelloWorldRepoInjector.LoadTypes(container);
        }
    }
}
