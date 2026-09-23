using Tyuiu.PolyakovaAB.Sprint3.Task6.V25.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(89,ds.GetSumTheDivisors(16, 24));
        }
    }
}
