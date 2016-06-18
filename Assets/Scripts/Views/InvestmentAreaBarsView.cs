using UnityEngine.UI;

public class InvestmentAreaBarsView : MvcBehaviour
{
    public Image PopularityBar;
    public Image HealthBar;
    public Image EducationBar;
    public Image SecurityBar;
    public Image CultureBar;
    public Image HabitationBar;
    public Image EnvironmentBar;

    void Update()
    {
        PopularityBar.fillAmount = App.Controller.InvestmentAreaBars.GetPopularityBarPercentage();
        HealthBar.fillAmount = App.Controller.InvestmentAreaBars.GetHealthBarPercentage();
        EducationBar.fillAmount = App.Controller.InvestmentAreaBars.GetEducationBarPercentage();
        SecurityBar.fillAmount = App.Controller.InvestmentAreaBars.GetSecurityBarPercentage();
        CultureBar.fillAmount = App.Controller.InvestmentAreaBars.GetCultureBarPercentage();
        HabitationBar.fillAmount = App.Controller.InvestmentAreaBars.GetHabitationBarPercentage();
        EnvironmentBar.fillAmount = App.Controller.InvestmentAreaBars.GetEnvironmentBarPercentage();
    }
}

