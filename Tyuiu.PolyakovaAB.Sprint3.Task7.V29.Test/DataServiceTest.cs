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
            double[] g = { -26.42,-28.10,-22.52,-20.21,-6.37,0.0,-1.93,3.40,8.49,13.04,21.47 };
            CollectionAssert.AreEqual(g,ds.GetMassFunction(-5,5));
        }
    }
}
