using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Ciclometru
{
    public struct Bicyclist
    {
        public string name;
        public int[] records;
        public int diameter;
        public Bicyclist(string nameBicyclist, int[] recordsBicyclist, int diameterBicyclist)
        {
            this.name = nameBicyclist;
            this.records = recordsBicyclist;
            this.diameter = diameterBicyclist;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceTraveledByCyclists()
        {
            var bicyclists = new Bicyclist[] { new Bicyclist("Alin", new int[] { 1, 2, 3 }, 3), new Bicyclist("Bogdan", new int[] { 2, 2, 4 }, 4), new Bicyclist("Silvian", new int[] { 2, 3, 5 }, 5) };
            Assert.AreEqual(6, DistanceTraveled(bicyclists));
        }
        int DistanceTraveled(Bicyclist[] bicyclists)
        {
            int result = 0;
            foreach (Bicyclist currentBicyclist in bicyclists)
            {
                result += DistanceOneBicyclists(currentBicyclist);
            }
            return result;
        }


        [TestMethod]
         public void DistanceOneBicyclists()
         {
             var bicyclists = new Bicyclist[] { new Bicyclist("Alin", new int[] { 1, 2, 3 }, 3)};
             Assert.AreEqual(2, DistanceOneBicyclists( new Bicyclist("Alin", new int[] { 1, 2, 3 }, 3)));
         }
         private static int DistanceOneBicyclists( Bicyclist currentBicyclist)
         {
             int result = 0;
             int totalDistance = 0;
             totalDistance = currentBicyclist.records.Sum();
             result += totalDistance / currentBicyclist.diameter;
             return result;
         }


         [TestMethod]
         public void RiderWithAverageSpeed()
         {
             var bicyclists = new Bicyclist[] { new Bicyclist("Alin", new int[] { 3, 3, 3 }, 2), new Bicyclist("Bogdan", new int[] { 4, 4, 4 }, 2), new Bicyclist("Silvian", new int[] { 6, 6, 6 }, 2) };
             Assert.AreEqual("Silvian", RiderWithAverageSpeed(bicyclists));
             var bicyclists1 = new Bicyclist[] { new Bicyclist("Silvian", new int[] { 6, 6, 6 }, 2) , new Bicyclist("Alin", new int[] { 3, 3, 3 }, 3), new Bicyclist("Bogdan", new int[] { 4, 4, 4 }, 4)};
             Assert.AreEqual("Silvian", RiderWithAverageSpeed(bicyclists1));
         }
        string RiderWithAverageSpeed(Bicyclist[] bicyclists)
         {
             int speed = 0;
            int counter=0;
            string result =string.Empty;
            string cursier=string.Empty;
            int AverageSpeed=0;
            for(int i=0; i<bicyclists.Length; i++)
            {
                foreach (Bicyclist time in bicyclists)
                {
                    counter++;
                }
                cursier = bicyclists[i].name;
                AverageSpeed = DistanceOneBicyclists(bicyclists[i]) / counter;
                if (speed < AverageSpeed) 
                {
                    speed = AverageSpeed;
                    result = cursier;
                }
                counter = 0;
            }
            return result;
         }


         [TestMethod]
        public void CyclistWithMaximumSpeed()
         {
             var bicyclists = new Bicyclist[] { new Bicyclist("Alin", new int[] { 3, 3, 3 }, 2), new Bicyclist("Bogdan", new int[] { 4, 4, 4 }, 2), new Bicyclist("Silvian", new int[] { 6, 6, 6 }, 2) };
             Assert.AreEqual("Silvian", CyclistWithMaximumSpeed(bicyclists));
         }
        string CyclistWithMaximumSpeed(Bicyclist[] bicyclists)
        {
            int second = 0;
            int[] counter = { 0 };
            for (int i = 0; i < bicyclists.Length;i++ )
            {
                foreach (Bicyclist currentBicyclist in bicyclists)
                {
                    counter = currentBicyclist.records;
                    if()
                }
            }
            return " a";
        }
    }
}