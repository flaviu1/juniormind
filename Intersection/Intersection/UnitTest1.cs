using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class UnitTest1
    {
        public enum Direction
        {
            up,
            down,
            right,
            left
        }
        public struct PointIntersection
        {
            public int x;
            public int y;
            public PointIntersection(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            Direction[] direction = new Direction[] {
                Direction.right,
                Direction.up,
                Direction.up,
                Direction.right,
                Direction.down,
                Direction.left
            };
            var pointIntersection = new PointIntersection(1, 1);
            Assert.AreEqual(pointIntersection, CheckIfIntersection(direction));
        }

        PointIntersection CheckIfIntersection(Direction[] direction)
        {
            int cordx = 0;
            int cordy = 0;
            PointIntersection intersection = new PointIntersection(0, 0);
            for (int i = 0; i < direction.Length; i++)
            {
                if (direction[i] == Direction.up) cordy++;
                if (direction[i] == Direction.down) cordy--;
                if (direction[i] == Direction.right) cordx++;
                if (direction[i] == Direction.left) cordx--;
            }
            intersection.x = cordx;
            intersection.y = cordy;
            return intersection;
        }
    }
}
