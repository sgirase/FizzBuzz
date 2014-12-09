using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApplication1
{

    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        [TestCase(1, 10, "Fizz", "Buzz")]
        ////This is expected to fail since my expected result only computes to maxRange of 10
        //[TestCase(1, 11, "Fizz", "Buzz")]
        public void PrintFizzBuzzReturnsExpectedResults(int minRange, int maxRange, string Fizz, string Buzz)
        {

            var objFb = new FizzBuzz(minRange, maxRange, Fizz, Buzz);
            string actualResults = objFb.PrintFizzBuzz();
            const string expectedResults = "1\n2\n3 Fizz\n4\n5 Buzz\n6 Fizz\n7\n8\n9 Fizz\n10 Buzz\n";
            Assert.That(actualResults, Is.EqualTo(expectedResults));
        }

        [Test]
        [TestCase(1, 0, "Fizz", "Buzz")]
        public void PrintFizzBuzz_ReturnsEmpty_InvalidMaxRange(int minRange, int maxRange, string Fizz, string Buzz)
        {
             var objFb = new FizzBuzz(minRange, maxRange, Fizz, Buzz);
            string actualResults = objFb.PrintFizzBuzz(); //will be empty string
            const string expectedResults = "1\n2\n3 Fizz\n4\n5 Buzz"; 
            Assert.IsFalse(Equals(actualResults, expectedResults));
        }
    }
}
