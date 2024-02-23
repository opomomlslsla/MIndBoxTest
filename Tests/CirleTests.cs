using ClassLibrary.Figures;
namespace Tests
{
    [TestClass]
    public class CirleTests
    {
        [TestMethod]
        public void AreaCalcTest()
        {
            double expected = 78.5;
            double expected2 = 153.86;
            double rad = 5;
            double rad2 = 7;
            Circle circ = new Circle();


            var res = circ.AreaCalc(rad);
            var res2 = circ.AreaCalc(rad2);
            
            Assert.AreEqual(expected, res, 0.1, "correct");
            Assert.AreEqual(expected2, res2, 0.1, "correct");
            
        }
    }
    
}