using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GojtievTK.sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            string monthName;
            switch (n)
            {
                case 0:
                    monthName = "Январь";
                    break;
                case 1:
                    monthName = "Февраль";
                    break;
                case 2:
                    monthName = "март";
                    break;
                case 3:
                    monthName = "Апрель";
                    break;
                case 4:
                    monthName = "Май";
                    break;
                case 5:
                    monthName = "Июнь";
                    break;
                case 6:
                    monthName = "Июль";
                    break;
                case 7:
                    monthName = "Август";
                    break;
                case 8:
                    monthName = "Сентябрь";
                    break;
                case 9:
                    monthName = "Октябрь";
                    break;
                case 10:
                    monthName = "Ноябрь";
                    break;
                case 11:
                    monthName = "Декабрь";
                    break;
                default:
                    monthName = "Некорректное значение (прошло больше года)";
                    break;
            }
            return monthName;
        }
    }
}
