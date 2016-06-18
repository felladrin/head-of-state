public class InvestmentAreaBarsController : MvcBehaviour
{
    static StateModel[] stateModels;

    void Start()
    {
        stateModels = new[] {
            App.Model.StateModel0,
            App.Model.StateModel1,
            App.Model.StateModel2,
            App.Model.StateModel3,
        };
    }

    public float GetPopularityBarPercentage()
    {
        return (GetHealthBarPercentage() + GetEducationBarPercentage() + GetSecurityBarPercentage() + GetCultureBarPercentage() + GetHabitationBarPercentage() + GetHabitationBarPercentage()) / 6;
    }

    public float GetHealthBarPercentage()
    {
        float sum = 0;

        foreach (StateModel state in stateModels)
        {
            sum += state.Health;
        }

        return sum / stateModels.Length;
    }

    public float GetEducationBarPercentage()
    {
        float sum = 0;

        foreach (StateModel state in stateModels)
        {
            sum += state.Education;
        }

        return sum / stateModels.Length;
    }

    public float GetSecurityBarPercentage()
    {
        float sum = 0;

        foreach (StateModel state in stateModels)
        {
            sum += state.Security;
        }

        return sum / stateModels.Length;
    }

    public float GetCultureBarPercentage()
    {
        float sum = 0;

        foreach (StateModel state in stateModels)
        {
            sum += state.Culture;
        }

        return sum / stateModels.Length;
    }

    public float GetHabitationBarPercentage()
    {
        float sum = 0;

        foreach (StateModel state in stateModels)
        {
            sum += state.Habitation;
        }

        return sum / stateModels.Length;
    }

    public float GetEnvironmentBarPercentage()
    {
        float sum = 0;

        foreach (StateModel state in stateModels)
        {
            sum += state.Environment;
        }

        return sum / stateModels.Length;
    }
}

