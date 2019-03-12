using System;
using NUnit.Framework;
using Src;

namespace Tests
{
    public class TestKata
    {
        [SetUp]
        public void Setup()
        {
        }

        private static void testing(long actual, long expected) 
        {
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Test1()
        {
            Console.WriteLine("Basic Tests PowerSumDigTerm");
            testing(Kata.PowerSumDigTerm(1), 81);
            testing(Kata.PowerSumDigTerm(2), 512);
            testing(Kata.PowerSumDigTerm(3), 2401);
            testing(Kata.PowerSumDigTerm(4), 4913);   
        }
    }
}