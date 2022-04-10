using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw3_algo_lib_cs;


namespace ce100_hw3_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LongestCommonSubsquence_TestMethod1()
        {
            string s1 = "AGGNKVSVMNVBNDKTAB";
            string s2 = "VHDSJKVHUIVHIGUGI";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, m, n);
            string expected = "VSVV";
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void LongestCommonSubsquence_TestMethod2()
        {
            string s1 = "LKSGNRSDLJGSDLJLSDJGGJADJ";
            string s2 = "RGJRIERIHGDHIRHKBMNVFBKNJKKJ";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, m, n);
            string expected = "RGJGDJ";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void LongestCommonSubsquence_TestMethod3()
        {
            string s1 = "XDVFKB";
            string s2 = "DLJVDLKB";


            int m = s1.Length;
            int n = s2.Length;
            string result = Class1.LongestCommonSubsquence(s1, s2, m, n);
            string expected = "DVKB";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod1()
        {
            int[] arr = new int[] { 34, 59, 53, 61, 77 };
            int n = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 375938);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod2()
        {
            int[] arr = new int[] { 249, 352, 422, 561, 653 };
            int n = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, 187153131);
        }

        [TestMethod]
        public void MatrixChainOrder_TestMethod3()
        {
            int[] arr = new int[] { 43, -58, 65, 77, -81 };
            int n = arr.Length;
            int res = Class1.MatrixChainOrder(arr, 1, n - 1);
            Assert.AreEqual(res, -793910);
        }
    }
}

