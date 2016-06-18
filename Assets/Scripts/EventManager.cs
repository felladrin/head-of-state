public delegate void InvestmentAreaChangedEventHandler(StateModel stateModel, InvestmentArea investmentArea);
public delegate void GamePausedEventHandler(bool paused);
public delegate void DateDayChangedEventHandler();
public delegate void DateMonthChangedEventHandler();
public delegate void DateYearChangedEventHandler();
public delegate void TickEventHandler();
public delegate void AlertClosedEventHandler();


public static class EventManager
{
    public static event InvestmentAreaChangedEventHandler OnInvestmentAreaChanged;
    public static event GamePausedEventHandler OnGamePaused;
    public static event DateDayChangedEventHandler OnDateDayChanged;
    public static event DateMonthChangedEventHandler OnDateMonthChanged;
    public static event DateYearChangedEventHandler OnDateYearChanged;
    public static event TickEventHandler OnTick;
    public static event AlertClosedEventHandler OnAlertClosed;

    public static void InvokeInvestmentAreaChanged(StateModel stateModel, InvestmentArea investmentArea)
    {
        if (OnInvestmentAreaChanged != null)
            OnInvestmentAreaChanged(stateModel, investmentArea);
    }

    public static void InvokeGamePaused(bool paused)
    {
        if (OnGamePaused != null)
            OnGamePaused(paused);
    }

    public static void InvokeDateDayChanged()
    {
        if (OnDateDayChanged != null)
            OnDateDayChanged();
    }

    public static void InvokeDateMonthChanged()
    {
        if (OnDateMonthChanged != null)
            OnDateMonthChanged();
    }

    public static void InvokeDateYearChanged()
    {
        if (OnDateYearChanged != null)
            OnDateYearChanged();
    }

    public static void InvokeTick()
    {
        if (OnTick != null)
            OnTick();
    }
    
    public static void InvokeAlertClosed()
    {
        if (OnAlertClosed != null)
            OnAlertClosed();
    }
}