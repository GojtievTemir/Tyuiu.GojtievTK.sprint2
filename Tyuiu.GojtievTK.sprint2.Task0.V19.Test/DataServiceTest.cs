using Tyuiu.GojtievTK.sprint2.Task0.V19.Lib;

namespace Tyuiu.GojtievTK.sprint2.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new bool[] { true, true, true, true, true, true }, ds.GetCompareOperations(105, 177));

        }
    }
}
