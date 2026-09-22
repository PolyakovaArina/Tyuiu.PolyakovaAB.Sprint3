using Tyuiu.PolyakovaAB.Sprint3.Task3.V6.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("ttable to stgh", ds.ReplaceNumOnChar("12able 1o s4gh", 't'));
        }
    }
}
