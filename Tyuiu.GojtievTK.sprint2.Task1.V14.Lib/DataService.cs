using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GojtievTK.sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                (a == b),
                (a != c),
                (a < b),
                (b > c),
                (c <= b || false),
                (a >= d && true)
            };
        }
    }
}
