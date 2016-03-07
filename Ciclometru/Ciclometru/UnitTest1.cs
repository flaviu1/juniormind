using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ciclometru
{
    public struct Ciclometru
    {
        public string nameCiclometru;
        public double rotationCiclometru;
        public double diameterCiclometru;
        public Ciclometru(string nameCiclometru, double rotationCiclometru, double diameterCiclometru)
        {
            this.nameCiclometru = nameCiclometru;
            this.rotationCiclometru = rotationCiclometru;
            this.diameterCiclometru = diameterCiclometru;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceTraveledByCyclists()
        {
            var distance = new Ciclometru[] { new Ciclometru("Alin", 1000, 10), new Ciclometru("Bogdan", 1100, 11), new Ciclometru("Silvian", 1200, 12) };
            Assert.AreEqual(300, DistanceTraveled(distance));
        }
        double DistanceTraveled(Ciclometru[] distance)
        {
            double result = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                result += DistanceTraveledByACyclist(distance, i);
            }
            return result;
        }

        private static double DistanceTraveledByACyclist(Ciclometru[] distance, int i)
        {
            double result = 0;
            result = (distance[i].rotationCiclometru / distance[i].diameterCiclometru);
            return result;
        }

        [TestMethod]
        public void AverageDrivingSpeed()
        {
            var distance = new Ciclometru[] { new Ciclometru("Alin", 1000, 10), new Ciclometru("Bogdan", 1100, 10), new Ciclometru("Silvian", 1200, 10) };
            Assert.AreEqual("Alin", AverageDrivingSpeed(distance));
        }
        string AverageDrivingSpeed(Ciclometru[] distance)
        {
            double result = 0;
            double counter = 0;
            int index = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                counter = (DistanceTraveledByACyclist(distance, i)) / (distance[i].rotationCiclometru / 60);
                if (counter > result)
                {
                    result = counter;
                    index = i;
                }
            }
            return distance[index].nameCiclometru;
        }
    }
}