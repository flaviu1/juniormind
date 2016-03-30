using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowersOfHanoi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFourDisc()
        {
            Assert.AreEqual(7, ChangeDiscWithMethodTowersHanoi(3));
            Assert.AreEqual(1023, ChangeDiscWithMethodTowersHanoi(10));
        }
        int ChangeDiscWithMethodTowersHanoi(int number)
        {
            if (number == 1) return 1;
            return (2 * ChangeDiscWithMethodTowersHanoi(number - 1)) + 1;
        }



        [TestMethod]
        public void Test()
        {
            int[] A=new int[] {3,2,1};
            int[] B=new int[A.Length];
            int[] C=new int[A.Length];
           CollectionAssert.AreEqual(new int[] {3,2,1} ,TowersOfHanoi(3,A ,B,C));
        }
        int[] TowersOfHanoi(int numberDisk ,int[] a ,int[] b, int[] c)
        {
            if (numberDisk == 1)
            {
                c[numberDisk - 1] = a[numberDisk - 1];
                Array.Resize(ref a, a.Length - 1);
                return a;   
            }
            else
            {
                TowersOfHanoi(numberDisk - 1, a, b, c);
                c[numberDisk - 1] = a[numberDisk - 1];
                Array.Resize(ref a, a.Length - 1);
                TowersOfHanoi(numberDisk - 1, c, b, a);
            }
            return c;
        }
    }
}
