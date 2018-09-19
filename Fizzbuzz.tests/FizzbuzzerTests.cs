using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.tests
{     
    [TestFixture]
    public class FizzbuzzerTests
    {
        FizzBuzzer fizzBuzzer;
        [SetUp]
        public void SetUp()
        {
            fizzBuzzer = new FizzBuzzer();
        }
        [Test]
        public void Get_Returns_1_For1()
        {
          
           String result =fizzBuzzer.Get(1);
            Assert.That(result, Is.EqualTo("1"));
        }
        [Test]
        public void Get_Returns_2_For_2()
        {
            
            string result =fizzBuzzer.Get(2);
            Assert.That(result, Is.EqualTo("2"));
        }
       
        [TestCase(3,"Fizz")]
        [TestCase(6,"Fizz")]
        public void Get_Returns_Expected2(int input,string output)
        {
            string result = fizzBuzzer.Get(input);
            Assert.That(result, Is.EqualTo(output));
        }


        [TestCase(5,"Buzz")]
        [TestCase(10, "Buzz")]
       
        public void Get_Returns_Expected(int input,string output)
        {
            //int input = 10;
            //string output = "Buzz";

            string result = fizzBuzzer.Get(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}
