using System;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using ClassicCodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern.Tests.Controllers
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestSingleton1()
        {
            var instance1 = Singleton1.GetInstance();
            Assert.IsNotNull(instance1);
            var instance2 = Singleton1.GetInstance();
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void TestSingleton2()
        {
            var instance1 = Singleton2.GetInstance();
            Assert.IsNotNull(instance1);
            var instance2 = Singleton2.GetInstance();
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void TestSingleton3()
        {
            var instance1 = Singleton3.GetInstance();
            Assert.IsNotNull(instance1);
            var instance2 = Singleton3.GetInstance();
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void TestSingleton2MultiThread()
        {
            Task<Singleton2> task1 = Task.Run(Singleton2.GetBadInstance);
            Task<Singleton2> task2 = Task.Run(Singleton2.GetBadInstance);
            Assert.AreNotSame(task1.Result, task2.Result);
        }
    }
}
