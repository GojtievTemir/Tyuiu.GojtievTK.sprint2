using Tyuiu.GojtievTK.sprint2.Task3.V27.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.25, ds.Calculate(0));

        }
    }
}
