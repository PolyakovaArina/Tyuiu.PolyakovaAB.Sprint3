using Tyuiu.PolyakovaAB.Sprint3.Task4.V4.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-35.317, ds.Calculate(-5, 5));
        }
    }
}
