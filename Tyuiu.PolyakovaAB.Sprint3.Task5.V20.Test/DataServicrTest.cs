using Tyuiu.PolyakovaAB.Sprint3.Task5.V20.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServicrTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(16839.467, ds.GetSumSumSeries(5, 1, 3, 1, 6));
        }
    }
}
