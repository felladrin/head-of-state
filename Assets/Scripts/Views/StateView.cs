using UnityEngine;
using UnityEngine.UI;

public class StateView : MvcBehaviour
{
    public StateModel Model;

    public Image HealthBar,
        CultureBar,
        HabitationBar,
        EducationBar,
        EnvironmentBar,
        SecurityBar;

    void Update()
    {
        HealthBar.fillAmount = Model.Health;
        CultureBar.fillAmount = Model.Culture;
        HabitationBar.fillAmount = Model.Habitation;
        EducationBar.fillAmount = Model.Education;
        EnvironmentBar.fillAmount = Model.Environment;
        SecurityBar.fillAmount = Model.Security;

        HealthBar.color = LerpRedGreen(HealthBar.fillAmount);
        CultureBar.color = LerpRedGreen(CultureBar.fillAmount);
        HabitationBar.color = LerpRedGreen(HabitationBar.fillAmount);
        EducationBar.color = LerpRedGreen(EducationBar.fillAmount);
        EnvironmentBar.color = LerpRedGreen(EnvironmentBar.fillAmount);
        SecurityBar.color = LerpRedGreen(SecurityBar.fillAmount);
    }

    static Color LerpRedGreen(float percentage)
    {
        return Color.Lerp(Color.red, Color.green, percentage);
    }
}

