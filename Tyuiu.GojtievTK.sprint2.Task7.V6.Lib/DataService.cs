using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GojtievTK.sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && (Math.Pow(x, 2) + Math.Pow(y, 2) > 1) )
            {
                return true; 
            }
            return false;

            

        }
    }
}
