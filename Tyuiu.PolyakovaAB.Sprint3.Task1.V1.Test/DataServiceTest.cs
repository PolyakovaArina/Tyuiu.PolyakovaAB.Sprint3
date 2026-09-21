using Tyuiu.PolyakovaAB.Sprint3.Task1.V1.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(5.311, ds.GetMultiplySeries(1, 7));
        }
    }
}
