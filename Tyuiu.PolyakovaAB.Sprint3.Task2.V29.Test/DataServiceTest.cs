using Tyuiu.PolyakovaAB.Sprint3.Task2.V29.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.186, ds.GetSumSeries(0.5, 1, 18));
        }
    }
}
