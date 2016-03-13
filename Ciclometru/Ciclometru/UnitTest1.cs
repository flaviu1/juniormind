﻿using System;
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


    public struct Maximum
    {
        public string name;
        public int second;
        public int diameter;
        public Maximum(string name, int second, int diameter)
        {
            this.name = name;
            this.second = second;
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
               result +=DistancetTraveledByACyclist(cyclists[i]);
            }
                return (int)result;
        }

        private static double DistancetTraveledByACyclist(Cyclist cyclists)
        {
            int sum = 0;
            sum = TheAmountOfRotationsOfACyclist(cyclists);
            return Math.PI * sum * cyclists.diameter;
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
               counter =AverageSpeedForOneCyclist(cyclist[i]);
                if(result<counter)
                {
                    result = counter;
                    index = i;
                }
            }
                return cyclist[index].name;
        }

        private static double AverageSpeedForOneCyclist(Cyclist cyclist)
        {
            int seconds = 0;
            seconds = cyclist.records.Length;
            return TheAmountOfRotationsOfACyclist(cyclist) / seconds;
        }


        [TestMethod]
        public void CyclistWithSpeedMaximum()
        {
            var cyclist = new Cyclist[] { new Cyclist("Alin", new int[] { 1, 2, 3 }, 3), new Cyclist("Bogdan", new int[] { 1, 2, 4 }, 3), new Cyclist("Silvian", new int[] { 1, 3, 6 }, 3) };
            var result = new Maximum("Silvian", 3 , 3);
            Assert.AreEqual(result, CyclistWithSpeedMaximum(cyclist));
        }
        Maximum CyclistWithSpeedMaximum(Cyclist[] cyclist)
        {
           int index = 0;
           Maximum[] maximum = new Maximum[1];
           double result = 0;
           double speed=0;
           for(int i=0;i<cyclist.Length;i++)
           {
               speed=SpeedForOneCyclist(cyclist[i]);
               if(result<speed)
               {
                   int second = 0;
                    result = speed;
                    index=i;
                    second+=SecondWhitMaximumSpeed(cyclist[index]);
                    AddToCyclistWhitSpeedMaximumNewStruct(cyclist, index, maximum);
               }
           }
           return maximum[0];
        }

        private static void AddToCyclistWhitSpeedMaximumNewStruct(Cyclist[] cyclist, int index, Maximum[] maximum)
        {
            for (int j = 0; j < maximum.Length; j++)
            {
                int second = 0;
                second += SecondWhitMaximumSpeed(cyclist[index]);
                maximum[j].name = cyclist[index].name;
                maximum[j].second = second;
                maximum[j].diameter = cyclist[index].diameter;
            }
        }

        private static int SecondWhitMaximumSpeed(Cyclist cyclist)
        {
            int counter = 0;
            int second=0;
            for (int j = 0; j < cyclist.records.Length; j++)
            {
                int count = 0;
                if (count < cyclist.records[j])
                {
                    counter = cyclist.records[j];
                    second = j;
                }
            }
            return second+1;
        }


        [TestMethod]
        public void SpeedOneCyclist()
        {
            var cyclist =  new Cyclist("Alin", new int[] { 1, 2, 3 }, 3);
            Assert.AreEqual(2,2, SpeedForOneCyclist(cyclist));
        }
        private static double SpeedForOneCyclist(Cyclist cyclist)
        {
            double distance = 0;
            int time = 0;
            distance = DistancetTraveledByACyclist(cyclist);
            time = cyclist.records.Length;
            return distance * time / 60;
        }
    }
}