using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Repo
{
    public class HelloWorldRepo : IHelloWorldRepo
    {
        public string GetHelloWorldEntity()
        {
            return "Hello World";
        }
    }
}
