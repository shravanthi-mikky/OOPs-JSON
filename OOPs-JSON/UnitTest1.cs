using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OOPs_JSON
{
    [TestClass]
    [System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            max abc = new max();
            int a = 1;
            int b = 2;
            int c = 3;
            int check = abc.MaxOfThree(a, b, c);
            Assert.AreEqual(check, 3);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
