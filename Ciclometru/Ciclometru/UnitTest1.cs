using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


namespace Ciclometru
{
    public struct Cyclist
    {
        public string name;
        public int[] records;
        public int diameter;
        public Cyclist(string name, int[] records, int diameter)
        {
            this.name = name;
            this.records = records;
            this.diameter = diameter;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceTraveledByCyclists()
        {
            var cyclist = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 3 }, 3), new Cyclist("Bogdan", new int[] { 1, 2, 4 }, 3), new Cyclist("Silvian", new int[] { 1, 3, 6 }, 3) };
            Assert.AreEqual(216, DistanceTraveled(cyclist));
        }
        int DistanceTraveled(Cyclist[] cyclists)
        {
            double result = 0;
            for ( int i = 0; i < cyclists.Length;i++)
            {
                int sum = 0;
                sum = Sum(cyclists[i], i);
                result += Math.PI * sum * cyclists[i].diameter;
            }
                return (int)result;
        }

        private static int Sum(Cyclist cyclists, int i)
        {
            int sum=0;
            for (int j = 0; j < cyclists.records.Length; j++)
            {
                sum += cyclists.records[j];
            }
            return sum;
        }

        [TestMethod]
        public void ForWoneCyclist()
        {
            var cyclist = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 3 }, 3), new Cyclist("Bogdan", new int[] { 1, 2, 4 }, 3), new Cyclist("Silvian", new int[] { 1, 3, 6 }, 3) };
            Assert.AreEqual("Silvian", AverageSpeeCdyclist(cyclist));
            var cyclist1 = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 3 }, 3), new Cyclist("Silvian", new int[] { 1, 3, 6 }, 3),new Cyclist("Bogdan", new int[] { 1, 2, 4 }, 3) };
            Assert.AreEqual("Silvian", AverageSpeeCdyclist(cyclist1));
        }
        string AverageSpeeCdyclist(Cyclist[] cyclist)
        {
            double result = 0;
            double counter=0;
            int index = 0;
            int seconds = 0;
            for (int i = 0; i < cyclist.Length; i++)
            {
                counter = 0;
                seconds = cyclist[i].records.Length;
                counter += Sum(cyclist[i], i)/seconds;
                if(result<counter)
                {
                    result = counter;
                    index = i;
                }
            }
                return cyclist[index].name;
        }
    }
}