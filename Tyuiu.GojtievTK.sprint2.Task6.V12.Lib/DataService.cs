using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GojtievTK.sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay;
            int prevMonth;
            int prevYear;

            if (n > 1)
            {
                prevDay = n - 1;
                prevMonth = m;
                prevYear = g;
            }
            else
            {
                prevMonth = (m == 1) ? 12 : m - 1;
                prevYear = (m == 1) ? g - 1 : g;

                prevDay = prevMonth switch
                {
                    1 => 31,
                    2 => 29,
                    3 => 31,
                    4 => 30,
                    5 => 31,
                    6 => 30,
                    7 => 31,
                    8 => 31,
                    9 => 30,
                    10 => 31,
                    11 => 30,
                    12 => 31,
                    _ => throw new ArgumentException("Некорректный номер месяца")
                };
            }

            return $"{prevDay:D2}.{prevMonth:D2}.{prevYear}";
        }

    }
}
