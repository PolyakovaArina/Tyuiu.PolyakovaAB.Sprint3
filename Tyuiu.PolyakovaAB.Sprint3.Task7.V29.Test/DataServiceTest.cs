using Tyuiu.PolyakovaAB.Sprint3.Task7.V29.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void DalidExpression()
        {
            DataService ds = new DataService();
            double[] g = { -32.26,-27.5,-22.8,-17.95,-12.97,-9.0,-0.31,3.77,8.57,13.42,18.28 };
            CollectionAssert.AreEqual(g,ds.GetMassFunction(-5,5));
        }
    }
}
