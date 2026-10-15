using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GojtievTK.sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22

    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool isInside = false;

            if (x >= 1 && x <= 4 && y >= 3 && y <= 6)
            {
                isInside = true;
            }

            if (x >= 7 && x <= 11 && y >= 3 && y <= 6)
            {
                isInside = true;
            }

            if (x >= 3 && x <= 12 && y >= 6 && y <= 8)
            {
                isInside = true;
            }

            if (x >= 2 && x <= 5 && y >= 8 && y <= 12)
            {
                isInside = true;
            }

            if (x >= 8 && x <= 10 && y >= 8 && y <= 12)
            {
                isInside = true;
            }

            if (x >= 2 && x <= 8 && y >= 13 && y <= 14)
            {
                isInside = true;
            }
            return isInside;
;
        }
    }
}
