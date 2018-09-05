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
            IAlgebra alg = new Algebra();

            var n = 7654321;

            Assert.AreEqual(7251444, alg.Phi(n));
        }

        [TestMethod]
        public void Test_Pow()
        {
            IAlgebra alg = new Algebra();

            var a = 24;
            var n = 5;

            Assert.AreEqual(7962624, alg.BinPow(a, n));
        }

        [TestMethod]
        public void Test_GCD_LCN()
        {
            IAlgebra alg = new Algebra();

            var a = 24;
            var b = 1024;

            Assert.AreEqual(8, alg.GCD(a, b));
            Assert.AreEqual(3072, alg.LCN(a, b));
        }
    }
}
