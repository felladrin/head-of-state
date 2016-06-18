using UnityEngine;

public class TimeModel : MvcBehaviour
{
    [SerializeField]
    [Tooltip("How many real-world seconds per in-game day.")]
    int secondsPerDay = 5;

    [SerializeField]
    [Tooltip("How many days per month.")]
    int daysPerMonth = 30;

    [SerializeField]
    [Tooltip("How many months per year.")]
    int monthsPerYear = 12;

    [SerializeField]
    [Tooltip("Current day in-game.")]
    int currentDay = 1;

    [SerializeField]
    [Tooltip("Current month in-game.")]
    int currentMonth = 1;

    [SerializeField]
    [Tooltip("Current year in-game.")]
    int currentYear = 2016;

    public int SecondsPerDay
    {
        get
        {
            return secondsPerDay;
        }
    }

    public int DaysPerMonth
    {
        get
        {
            return daysPerMonth;
        }
    }

    public int MonthsPerYear
    {
        get
        {
            return monthsPerYear;
        }
    }

    public int CurrentDay
    {
        get
        {
            return currentDay;
        }
    }

    public int CurrentMonth
    {
        get
        {
            return currentMonth;
        }
    }

    public int CurrentYear
    {
        get
        {
            return currentYear;
        }
    }

    public void IncreaseCurrentDay(int quantity = 1)
    {
        currentDay += quantity;
    }

    public void IncreaseCurrentMonth(int quantity = 1)
    {
        currentDay = 1;
        currentMonth += quantity;
    }

    public void IncreaseCurrentYear(int quantity = 1)
    {
        currentMonth = 1;
        currentYear += quantity;
    }
}
