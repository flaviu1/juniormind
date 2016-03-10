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


        [TestMethod]
        public void SumWhoneCyclist()
        {
            var cyclist = new Cyclist("Alin", new int[] { 1, 2, 3 }, 3);
            int i = cyclist.records.Length;
            Assert.AreEqual(6, Sum(cyclist,i));
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


        [TestMethod]
        public void CyclistWithSpeedMaximum()
        {
            var cyclist = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 9 }, 3), new Cyclist("Bogdan", new int[] { 1, 2, 4 }, 3), new Cyclist("Silvian", new int[] { 1, 3, 6 }, 3) };
            Assert.AreEqual("Alin", CyclistWithSpeedMaximum(cyclist));
        }
        string CyclistWithSpeedMaximum(Cyclist[] cyclist)
        {
           int index1 = 0;
           double result = 0;
           int counter=0;
           for(int i=0;i<cyclist.Length;i++)
           {
               for (int j = 0; j < cyclist[i].records.Length;j++)
               {
                   counter=cyclist[i].records[j];
                   if (result < counter)
                   {
                       result = counter;
                       index1 = i;
                   }
               }
           }
           return cyclist[index1].name;
        }
    }
}