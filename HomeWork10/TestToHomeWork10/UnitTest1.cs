namespace HomeWork10.Tests
{
    [TestClass]
    public class PointsTest
    {
        [TestMethod]
        public void TestDistancePoint()
        {
            Point point = new Point(1, 8);
            Point point2 = new Point(2, 6);

            double actual = point.Distance(point2);
            double expected = 2.23606797749979;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            Point p1 = new Point(1, 8);
            Point p2 = new Point(2, 6);
            Point p3 = new Point(3, 7);
            Triangle triangle = new Triangle(p1, p2, p3);
            double actual = triangle.Perimeter();
            double expected = 5.8863495173726745;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSquare()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 3);
            Point p3 = new Point(4, 0);
            Triangle triangle = new Triangle(p1, p2, p3);
            double expected = 1.4999999999999998;

            double actual = triangle.Square();

            Assert.AreEqual(6.0, actual);
        }

        [TestMethod]
        public void TestDistanceTriangle()
        {
            Point point = new Point(1, 8);
            Point point2 = new Point(2, 6);
            Point point3 = new Point(3, 7); 
            Triangle tr = new Triangle(point, point2, point3);

            double actual = tr.Distance(point, point2);
            double expected = 2.23606797749979;

            Assert.AreEqual(expected, actual);
        }
    }
}