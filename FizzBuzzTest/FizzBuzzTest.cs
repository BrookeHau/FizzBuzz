using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void returnFizzforMultipleOfThree()
        {
            //arranage
            double a = 3;
            String expected = "fizz";
            FizzBuzzCode fizzbuzz = new FizzBuzzCode(a);
            String actual = fizzbuzz.getText();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnBuzzforMultipleOfFive()
        {
            //arranage
            double a = 5;
            String expected = "buzz";
            FizzBuzzCode fizzbuzz = new FizzBuzzCode(a);
            String actual = fizzbuzz.getText();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void returnFizzBuzzforBoth()
        {
            //arranage
            double a = 15;
            String expected = "fizzbuzz";
            FizzBuzzCode fizzbuzz = new FizzBuzzCode(a);
            String actual = fizzbuzz.getText();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnNeither()
        {
            //arranage
            double a = 22;
            String expected = "neither";
            FizzBuzzCode fizzbuzz = new FizzBuzzCode(a);
            String actual = fizzbuzz.getText();
            Assert.AreEqual(expected, actual);
        }

    }

    
}
