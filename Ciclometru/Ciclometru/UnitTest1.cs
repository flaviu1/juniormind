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
               result +=DistancetTraveledByACyclist(cyclists, i);
            }
                return (int)result;
        }

        private static double DistancetTraveledByACyclist(Cyclist[] cyclists, int i)
        {
            int sum = 0;
            sum = TheAmountOfRotationsOfACyclist(cyclists[i]);
            return Math.PI * sum * cyclists[i].diameter;
        }


        [TestMethod]
        public void SumWhoneCyclist()
        {
            var cyclist = new Cyclist("Alin", new int[] { 1, 2, 3 }, 3);
            int i = cyclist.records.Length;
            Assert.AreEqual(6, TheAmountOfRotationsOfACyclist(cyclist));
        }
        private static int TheAmountOfRotationsOfACyclist(Cyclist cyclists)
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
            for (int i = 0; i < cyclist.Length; i++)
            {
                counter = 0;
               counter+=AverageSpeedForOneCyclist(cyclist, i);
                if(result<counter)
                {
                    result = counter;
                    index = i;
                }
            }
                return cyclist[index].name;
        }

        private static double AverageSpeedForOneCyclist(Cyclist[] cyclist, int i)
        {
            int seconds = 0;
            seconds = cyclist[i].records.Length;
            return TheAmountOfRotationsOfACyclist(cyclist[i]) / seconds;
        }


        [TestMethod]
        public void CyclistWithSpeedMaximum()
        {
            var cyclist = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 3 }, 3), new Cyclist("Bogdan", new int[] { 1, 2, 4 }, 3), new Cyclist("Silvian", new int[] { 1, 3, 6 }, 3) };
            Assert.AreEqual("Silvian", CyclistWithSpeedMaximum(cyclist));
        }
        string CyclistWithSpeedMaximum(Cyclist[] cyclist)
        {
           int index1 = 0;
           double result = 0;
           double speed=0;
           for(int i=0;i<cyclist.Length;i++)
           {
               speed=SpeedForOneCyclist(cyclist, i);
               if(result<speed)
               {
                   result = speed;
                   index1 = i;
               }
           }
           return cyclist[index1].name;
        }


        [TestMethod]
        public void SpeedOneCyclist()
        {
            var cyclist = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 3 }, 3)};
            Assert.AreEqual(2,2, SpeedForOneCyclist(cyclist,0));
        }
        private static double SpeedForOneCyclist(Cyclist[] cyclist, int i)
        {
            double distance = 0;
            int time = 0;
            distance = DistancetTraveledByACyclist(cyclist, i);
            time = cyclist[i].records.Length;
            return distance * time / 60;
        }
    }
}