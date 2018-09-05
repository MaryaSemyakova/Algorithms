using ElementaryAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorythms.UnitTest
{
    [TestClass]
    public class AlgorythmsUnitTest
    {      
        [TestMethod]
        public void Test_IrreducableBasicFractions()
        {
            var alg = new Algebra();

            var n = 7654321;

            Assert.AreEqual(7251444, alg.Phi(n));
        }

        [TestMethod]
        public void Test_Pow()
        {
            var alg = new Algebra();

            var a = 24;
            var n = 5;

            Assert.AreEqual(7962624, alg.BinPow(a, n));
        }
    }
}
