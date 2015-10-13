using System;
using System.Diagnostics;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class fizzbuzztest
    {
        [Test]
        public void number_one_returns_alphanumeric_1()
        {
            RunTest(1, "1");
        }

        [Test]
        public void number_two_returns_alphanumeric_2()
        {
            RunTest(2, "2");
        }

        [Test]
        public void number_three_returns_fizz()
        {
            RunTest(3, "fizz");
        }

        [Test]
        public void number_five_returns_buzz()
        {
            RunTest(5, "buzz");
        }

        [Test]
        public void number_15_returns_fizzbuzz()
        {
            RunTest(15, "fizzbuzz");
        }

        static void RunTest(int i, string expected)
        {
            var subject = new FizzBuzzer();
            var actual = subject.Do(i);
            Assert.AreEqual(expected, actual);
        }
    }

    internal class FizzBuzzer
    {
        public string Do(int i)
        {
            if (i%3 == 0 && i%5 == 0)
                return "fizzbuzz";

            if (i%3 == 0)
                return "fizz";

            if (i%5 == 0)
                return "buzz";

            return i.ToString();
        }
    }
}
