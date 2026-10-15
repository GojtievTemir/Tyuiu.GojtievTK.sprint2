using Tyuiu.GojtievTK.sprint2.Task1.V14.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new bool[] { false, true, true, true, true, false }, ds.GetLogicOperations(185, 216, 174, 917));

        }
    }
}
