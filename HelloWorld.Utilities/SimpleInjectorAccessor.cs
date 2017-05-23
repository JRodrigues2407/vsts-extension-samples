using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace HelloWorld.Utilities
{
    public static class SimpleInjectorAccessor
    {
        private static Container _container;

        public static Container Container
        {
            get { return _container; }
        }

        public static void RegisterContainer(Container container)
        {
            _container = container;
        }

        public static void Load(Action<Container> loadSimpleInjector)
        {
            loadSimpleInjector(_container);
        }
    }
}
