using Tyuiu.GojtievTK.sprint2.Task7.V6.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 0));
        }
    }
}
