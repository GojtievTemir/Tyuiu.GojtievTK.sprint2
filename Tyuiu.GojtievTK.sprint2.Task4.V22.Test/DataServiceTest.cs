using Tyuiu.GojtievTK.sprint2.Task4.V22.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(11, ds.Calculate(1,1));

        }
    }
}

