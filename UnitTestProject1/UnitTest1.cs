using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private void assert(bool exp)
        {
            if (!exp)
                throw new Exception();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Action action = Foo;
            var x = Assert.ThrowsException<ArgumentException>(() =>Foo(3));
        }
        private void Foo(int f)
        {
            throw new NotImplementedException();
        }
    }
}
