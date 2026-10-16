using Tyuiu.GojtievTK.sprint2.Task5.V7.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindMonthName(1990, 0));
        }
    }
}
