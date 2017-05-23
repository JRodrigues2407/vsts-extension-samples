using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Repo;

namespace HelloWorld.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        private IHelloWorldRepo _helloWorldRepo;

        public HelloWorldService(IHelloWorldRepo helloWorldRepo)
        {
            _helloWorldRepo = helloWorldRepo;
        }
        public string GetStartMessage(bool isCodingExercise)
        {
            return isCodingExercise ? _helloWorldRepo.GetHelloWorldEntity() : "Foo";
        }
    }
}
