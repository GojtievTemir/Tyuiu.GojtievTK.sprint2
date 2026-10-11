using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GojtievTK.sprint2.Task0.V19.Lib

{
    public class DataService : ISprint2Task0V19
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[]
            {
        x * 0 == y * 0,
        x != y,
        x < y,
        y > x,
        x <= y,
        y >= x
            };


            return res;
        }
    }
}
