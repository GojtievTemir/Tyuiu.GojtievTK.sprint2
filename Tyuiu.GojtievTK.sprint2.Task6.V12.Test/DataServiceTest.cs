using Tyuiu.GojtievTK.sprint2.Task6.V12.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("05.12.2008", ds.FindDateOfPreviousDay(2008, 12, 6));
        }
    }
}
