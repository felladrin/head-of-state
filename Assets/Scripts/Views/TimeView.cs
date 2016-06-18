using UnityEngine.UI;

public class TimeView : MvcBehaviour
{
    public Text DayNumber, MonthNumber, YearNumber;

    public void SetDayNumber(int value)
    {
        DayNumber.text = value.ToString().PadLeft(2, '0');
    }

    public void SetMonthNumber(int value)
    {
        MonthNumber.text = value.ToString().PadLeft(2, '0');
    }

    public void SetYearNumber(int value)
    {
        YearNumber.text = value.ToString().PadLeft(2, '0');
    }
}
