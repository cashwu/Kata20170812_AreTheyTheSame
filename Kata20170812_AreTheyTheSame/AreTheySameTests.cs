using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170812_AreTheyTheSame
{
    [TestClass]
    public class AreTheySameTests
    {
        [TestMethod]
        public void input_2_and_4_should_return_true()
        {
            var a = new[] { 2 };
            var b = new[] { 4 };

            TheySameShouldBeTrue(a, b);
        }

        [TestMethod]
        public void input_2_and_5_should_return_false()
        {
            var a = new[] { 2 };
            var b = new[] { 5 };

            TheySameShouldBeFalse(a, b);
        }

        private static void TheySameShouldBeFalse(int[] a, int[] b)
        {
            Assert.IsFalse(new AreTheySame().comp(a, b));
        }

        private static void TheySameShouldBeTrue(int[] a, int[] b)
        {
            Assert.IsTrue(new AreTheySame().comp(a, b));
        }
    }

    public class AreTheySame
    {
        public bool comp(int[] a, int[] b)
        {
            return a[0] * a[0] == b[0];
        }
    }
}
