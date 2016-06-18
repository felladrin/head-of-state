public class TimeController : MvcBehaviour
{
    void Start()
    {
        InvokeRepeating("Tick", 1, 1);
        InvokeRepeating("DateChange", App.Model.Time.SecondsPerDay, App.Model.Time.SecondsPerDay);
    }

    void Tick()
    {
        EventManager.InvokeTick();
    }

    void DateChange()
    {
        TimeModel model = App.Model.Time;
        TimeView view = App.View.Time;

        model.IncreaseCurrentDay();
        EventManager.InvokeDateDayChanged();

        if (model.CurrentDay > model.DaysPerMonth)
        {
            model.IncreaseCurrentMonth();
            view.SetMonthNumber(model.CurrentMonth);
            EventManager.InvokeDateMonthChanged();
        }

        if (model.CurrentMonth > model.MonthsPerYear)
        {
            model.IncreaseCurrentYear();
            view.SetYearNumber(model.CurrentYear);
            EventManager.InvokeDateYearChanged();
        }
        
        view.SetDayNumber(model.CurrentDay);
    }
}
