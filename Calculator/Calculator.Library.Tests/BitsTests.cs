using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator.Library.Tests
{
    class BitsTests
    {
        [Test]
        public void TestConstructor1()
        {
            Bits bits = new Bits("101010");
            string expected = "101010";
            string actual = bits.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestConstructor2()
        {
            Bits bits = new Bits("101010", true);
            string expected = "-101010";
            string actual = bits.ToString();
            Assert.AreEqual(expected, actual);

            bits = new Bits("11111", false);
            expected = "11111";
            actual = bits.ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestXor()
        {
            Bits a = new Bits("10101010");
            Bits b = new Bits("11110000");
            string expected = "1011010";
            Bits c = a.Xor(b);
            string actual = c.ToString();
            Assert.AreEqual(expected, actual);

            // Also check for +, - bits as well.
            // Check for uneven bits (e.g. the number of bits in a and b are different, e.g. b.Length > a.Length as well as a.Length > b.Length)
        }
    }
}
