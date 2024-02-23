using ClassLibrary.Figures;
using System;

namespace Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaCalcTest()
        {
            double expected = 6;
            double expected2 = 12;
            double a = 3;
            double b = 4;
            double c = 5;
            double d = 5;
            double e = 8;

            TriangleNew triang = new TriangleNew();


            var res = triang.AreaCalc(a,b,c);
            var res2 = triang.AreaCalc(c,d,e);
            

            Assert.AreEqual(expected, res, 0.1, "not correct");
            Assert.AreEqual(expected2, res2, 0.1, "not correct");

        }
        [TestMethod]
        public void IsRigtTest()
        {

            double a = 3;
            double b = 4;
            double c = 5;
            double d = 5;
            double e = 8;

            TriangleNew triangle = new TriangleNew();

            var res3 = triangle.IsRight(a, b, c);
            var res4 = triangle.IsRight(c, d, e);

            Assert.AreEqual(true, res3, "not correct");
            Assert.AreEqual(true, res4, "not correct");
        }
    }

}