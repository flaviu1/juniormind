using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

         
        }
        public class Example
        {
            public static void Main()
            {
                Random rnd = new Random();

                Console.WriteLine("\n X random Letter small:");
                for (char c = 'a'; c <= 'z'; c++)
                {
                    Console.Write("{0,6}", rnd.Next('a', 'z'));
                    if (c % 5 == 0) Console.WriteLine();
                }
                Console.WriteLine("\n X random Letter bigg:");
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    Console.Write("{0,6}", rnd.Next('A','Z'));
                    if (c % 5 == 0) Console.WriteLine();
                }
                Console.WriteLine("\n X random integers from 1 to 20:");
                for (int i = 1; i <= 20; i++)
                {
                    Console.Write("{0,8}", rnd.Next(1, 20));
                    if (i % 5 == 0) Console.WriteLine();
                }
            }
        }
    }
}
