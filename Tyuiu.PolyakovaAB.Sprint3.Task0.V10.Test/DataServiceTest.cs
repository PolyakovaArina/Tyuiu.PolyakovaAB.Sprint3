using Tyuiu.PolyakovaAB.Sprint3.Task0.V10.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 1;
            int c = 5;
            Assert.AreEqual(0.033, ds.GetMultiplySeries(a, b, c));
        }
    }
}
