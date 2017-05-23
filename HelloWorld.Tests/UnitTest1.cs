using HelloWorld.Services;
using System;
using FakeItEasy;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Repo;

namespace HelloWorld.Services.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        private HelloWorldService _helloWorldService;
        private IHelloWorldRepo _helloWorldRepo;

        [TestInitialize]
        public void Initialize()
        {
            _helloWorldRepo = A.Fake<IHelloWorldRepo>();
            _helloWorldService = new HelloWorldService(_helloWorldRepo);

            A.CallTo(() => _helloWorldRepo.GetHelloWorldEntity()).Returns("Hello World");
        }

        [TestMethod()]
        public void GetHelloWorldEntityTest()
        {
            var result = _helloWorldRepo.GetHelloWorldEntity();
            Assert.AreEqual("Hello World", result);
        }


        [TestMethod()]
        public void GetStartMessageTest1()
        {
            var result = _helloWorldRepo.GetHelloWorldEntity();
            Assert.AreEqual("Hello World", result);
        }
        [TestMethod()]
        public void GetStartMessageTest2()
        {
            var result = _helloWorldService.GetStartMessage(false);
            Assert.AreEqual("Foo", result);
        }
    }
}
