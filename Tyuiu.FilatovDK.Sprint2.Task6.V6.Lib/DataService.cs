using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilatovDK.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            {
                switch (value1)
                {
                    case 1:
                        switch (value2)
                        {
                            case 6: return "шестёрка пик";
                            case 7: return "семёрка пик";
                            case 8: return "восьмёрка пик";
                            case 9: return "девятка пик";
                            case 10: return "десятка пик";
                            case 11: return "валет пик";
                            case 12: return "дама пик";
                            case 13: return "король пик";
                            case 14: return "туз пик";
                        }
                        return "Введено неправильное число ";

                    case 2:
                        switch (value2)
                        {
                            case 6: return "шестёрка треф";
                            case 7: return "семёрка треф";
                            case 8: return "восьмёрка треф";
                            case 9: return "девятка треф";
                            case 10: return "десятка треф";
                            case 11: return "валет треф";
                            case 12: return "дама треф";
                            case 13: return "король треф";
                            case 14: return "туз треф";
                        }
                        return "Введено неправильное число ";

                    case 3:
                        switch (value2)
                        {
                            case 6: return "шестёрка бубен";
                            case 7: return "семёрка бубен";
                            case 8: return "восьмёрка бубен";
                            case 9: return "девятка бубен";
                            case 10: return "десятка бубен";
                            case 11: return "валет бубен";
                            case 12: return "дама бубен";
                            case 13: return "король бубен";
                            case 14: return "туз бубен";
                        }
                        return "Введено неправильное число ";

                    case 4:
                        switch (value2)
                        {
                            case 6: return "шестёрка черви";
                            case 7: return "семёрка черви";
                            case 8: return "восьмёрка черви";
                            case 9: return "девятка черви";
                            case 10: return "десятка черви";
                            case 11: return "валет черви";
                            case 12: return "дама черви";
                            case 13: return "король черви";
                            case 14: return "туз черви";
                        }
                        return "Введено неправильное число ";
                    default: return "Введено неправильное число";
                }
            }
        }
    }
}
