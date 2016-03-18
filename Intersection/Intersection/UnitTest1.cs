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
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
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
            var pointIntersection = new Point(1, 1);
            Assert.AreEqual(pointIntersection, CheckIfIntersection(direction));
        }
        [TestMethod]
        public void CeckPoint()
        {
            Direction[] direction = new Direction[] {
                Direction.right,
                Direction.up,
                Direction.up,
                Direction.right,
                Direction.down,
                Direction.left,
                 Direction.left,
                 Direction.left
            };
            var pointIntersection = new Point(1, 1);
            Assert.AreEqual(pointIntersection, CheckIfIntersection(direction));
        }
        Point CheckIfIntersection(Direction[] direction)
        {
            Point intersection = new Point(0, 0);
            Point[] intersection2 = new Point[direction.Length];
            for (int i = 0; i < direction.Length; i++)
            {
                if (direction[i] == Direction.up) intersection.y +=1 ;
                if (direction[i] == Direction.down) intersection.y -= 1;
                if (direction[i] == Direction.right) intersection.x += 1;
                if (direction[i] == Direction.left) intersection.x -= 1;

                for(int j=0;j<intersection2.Length;j++)
                {
                    if (intersection2[j].x == intersection.x && intersection2[j].y == intersection.y)
                        return intersection;
                }
                intersection2[i].x = intersection.x;
                intersection2[i].y = intersection.y;
            }
            return intersection;
        }
    }
}
