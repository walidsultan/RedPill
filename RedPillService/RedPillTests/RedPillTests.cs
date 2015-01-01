using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using knockknock.readify.net.RedPillTests.RedPillServiceReference;

namespace knockknock.readify.net.RedPillTests
{
    [TestClass]
    public class RedPillTests
    {
        [TestMethod]
        public void FibonacciNumber()
        {
            RedPillClient redPill = new RedPillClient();

            Assert.AreEqual(-3, redPill.FibonacciNumber(-4), "F(-4) is wrong");
            Assert.AreEqual(5, redPill.FibonacciNumber(-5), "F(-5) is wrong");
            Assert.AreEqual(0, redPill.FibonacciNumber(0), "F(0) is wrong");
            Assert.AreEqual(1, redPill.FibonacciNumber(1), "F(1) is wrong");
            Assert.AreEqual(-8, redPill.FibonacciNumber(-6), "F(-6) is wrong");
            Assert.AreEqual(2, redPill.FibonacciNumber(3), "F(3) is wrong");
            Assert.AreEqual(3, redPill.FibonacciNumber(4), "F(4) is wrong");
            Assert.AreEqual(5, redPill.FibonacciNumber(5), "F(5) is wrong");
            Assert.AreEqual(8, redPill.FibonacciNumber(6), "F(6) is wrong");
            Assert.AreEqual(13, redPill.FibonacciNumber(7), "F(7) is wrong");
            Assert.AreEqual(1836311903, redPill.FibonacciNumber(46), "F(46) is wrong");
            Assert.AreEqual(2971215073, redPill.FibonacciNumber(47), "F(47) is wrong");
            Assert.AreEqual(7540113804746346429, redPill.FibonacciNumber(92), "F(92) is wrong");
            Assert.AreEqual(1, redPill.FibonacciNumber(2), "F(2) is wrong");
            Assert.AreEqual(2, redPill.FibonacciNumber(-3), "F(-3) is wrong");
            Assert.AreEqual(-1, redPill.FibonacciNumber(-2), "F(-2) is wrong");
            Assert.AreEqual(1, redPill.FibonacciNumber(-1), "F(-1) is wrong");
            Assert.AreEqual(-7540113804746346429, redPill.FibonacciNumber(-92), "F(-92) is wrong");
            Assert.AreEqual(2971215073, redPill.FibonacciNumber(-47), "F(-47) is wrong");
            Assert.AreEqual(-1836311903, redPill.FibonacciNumber(-46), "F(-46) is wrong");
            Assert.AreEqual(13, redPill.FibonacciNumber(-7), "F(-7) is wrong");

            try
            {
                redPill.FibonacciNumber(93);
                Assert.Fail("ArgumentOutOfRangeException is expected");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Fib(>92) will cause a 64-bit integer overflow.\r\nParameter name: n", ex.Message, "F(93) is wrong");
            }

            try
            {
                redPill.FibonacciNumber(-93);
                Assert.Fail("ArgumentOutOfRangeException is expected");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Fib(<-92) will cause a 64-bit integer overflow.\r\nParameter name: n", ex.Message, "F(-93) is wrong");
            }
        }

        [TestMethod]
        public void WhatShapeIsThis()
        {
            RedPillClient redPill = new RedPillClient();
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(0, 0, 0), "(0, 0, 0) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 1, 0), "(1, 1, 0) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 1, 2), "(1, 1, 2) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 0, 1), "(1, 0, 1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(2, 1, 1), "(2, 1, 1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 2, 3), "(1, 2, 3) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 1, 2147483647), "(1, 1, 2147483647) is wrong.");
            Assert.AreEqual(TriangleType.Equilateral, redPill.WhatShapeIsThis(1, 1, 1), "(1, 1, 1) is wrong.");
            Assert.AreEqual(TriangleType.Equilateral, redPill.WhatShapeIsThis(2, 2, 2), "(2, 2, 2) is wrong.");
            Assert.AreEqual(TriangleType.Equilateral, redPill.WhatShapeIsThis(2147483647, 2147483647, 2147483647), "(2147483647, 2147483647, 2147483647) is wrong.");
            Assert.AreEqual(TriangleType.Isosceles, redPill.WhatShapeIsThis(2, 2, 3), "(2, 2, 3) is wrong.");
            Assert.AreEqual(TriangleType.Isosceles, redPill.WhatShapeIsThis(2, 3, 2), "(2, 3, 2) is wrong.");
            Assert.AreEqual(TriangleType.Isosceles, redPill.WhatShapeIsThis(3, 2, 2), "(3, 2, 2) is wrong.");
            Assert.AreEqual(TriangleType.Scalene, redPill.WhatShapeIsThis(2, 3, 4), "(2, 3, 4) is wrong.");
            Assert.AreEqual(TriangleType.Scalene, redPill.WhatShapeIsThis(3, 4, 2), "(3, 4, 2) is wrong.");
            Assert.AreEqual(TriangleType.Scalene, redPill.WhatShapeIsThis(4, 2, 3), "(4, 2, 3) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 2, 1), "(1, 2, 1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(-2147483648, -2147483648, -2147483648), "(-2147483648, -2147483648, -2147483648) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(-1, -1, -1), "(-1, -1, -1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(-1, 1, 1), "(-1, 1, 1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, -1, 1), "(1, -1, 1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(1, 1, -1), "(1, 1, -1) is wrong.");
            Assert.AreEqual(TriangleType.Error, redPill.WhatShapeIsThis(0, 1, 1), "(0, 1, 1) is wrong.");
            Assert.AreEqual(TriangleType.Equilateral, redPill.WhatShapeIsThis(2147483647, 2147483647, 2147483647), "(2147483647, 2147483647, 2147483647) is wrong.");
        }

        [TestMethod]
        public void ReverseWords()
        {
            RedPillClient redPill = new RedPillClient();
            Assert.AreEqual("tac", redPill.ReverseWords("cat"));
            Assert.AreEqual("gniliart ecaps ", redPill.ReverseWords("trailing space "));
            Assert.AreEqual("!gnaB", redPill.ReverseWords("Bang!"));
            Assert.AreEqual(string.Empty, redPill.ReverseWords(""));
            Assert.AreEqual("tac dna god", redPill.ReverseWords("cat and dog"));
            Assert.AreEqual("owt  secaps", redPill.ReverseWords("two  spaces"));
            Assert.AreEqual(" gnidael ecaps", redPill.ReverseWords(" leading space"));
            Assert.AreEqual("latipaC", redPill.ReverseWords("Capital"));
            Assert.AreEqual("sihT si a :krans ®¸â", redPill.ReverseWords("This is a snark: â¸®"));
            Assert.AreEqual("n)o(i*t&a^u%t$c#n@u!P", redPill.ReverseWords("P!u@n#c$t%u^a&t*i(o)n"));
            Assert.AreEqual("detartrated kayak detartrated", redPill.ReverseWords("detartrated kayak detartrated"));
            Assert.AreEqual("?©ÃuQ¿Â", redPill.ReverseWords("Â¿QuÃ©?"));
            Assert.AreEqual("  S  P  A  C  E  Y  ", redPill.ReverseWords("  S  P  A  C  E  Y  "));
            Assert.AreEqual("!S!G!N!A!B!", redPill.ReverseWords("!B!A!N!G!S!"));

            try
            {
                redPill.ReverseWords(null);
                Assert.Fail("ArgumentNullException is expected");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Value cannot be null.\r\nParameter name: s", ex.Message);
            }
        }
    }
}
