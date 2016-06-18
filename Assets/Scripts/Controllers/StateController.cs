using UnityEngine;
using System.Collections;

public class StateController : MvcBehaviour
{
    public GameObject HourglassPrefab;
    public int CooldownTime = 10;
    public int PercentageIncreasePerUpdagrade = 20;

    static StateModel[] stateModels;

    void OnEnable()
    {
        EventManager.OnTick += OnTick;
        EventManager.OnDateDayChanged += ExecutePopulationGrowth;
    }

    void OnDisable()
    {
        EventManager.OnTick -= OnTick;
        EventManager.OnDateDayChanged -= ExecutePopulationGrowth;
    }

    void Start()
    {
        stateModels = new[] {
            App.Model.StateModel0,
            App.Model.StateModel1,
            App.Model.StateModel2,
            App.Model.StateModel3,
        };
    }

    void OnTick()
    {
        foreach (StateModel state in stateModels)
        {
            if (state.HealthCooldown > 0)
            {
                state.HealthInvestment += state.Population * PercentageIncreasePerUpdagrade / 100 / CooldownTime;
                state.HealthCooldown--;
            }

            if (state.SecurityCooldown > 0)
            {
                state.SecurityInvestment += state.Population * PercentageIncreasePerUpdagrade / 100 / CooldownTime;
                state.SecurityCooldown--;
            }

            if (state.EducationCooldown > 0)
            {
                state.EducationInvestment += state.Population * PercentageIncreasePerUpdagrade / 100 / CooldownTime;
                state.EducationCooldown--;
            }

            if (state.CultureCooldown > 0)
            {
                state.CultureInvestment += state.Population * PercentageIncreasePerUpdagrade / 100 / CooldownTime;
                state.CultureCooldown--;
            }

            if (state.HabitationCooldown > 0)
            {
                state.HabitationInvestment += state.Population * PercentageIncreasePerUpdagrade / 100 / CooldownTime;
                state.HabitationCooldown--;
            }

            if (state.EnvironmentCooldown > 0)
            {
                state.EnvironmentInvestment += state.Population * PercentageIncreasePerUpdagrade / 100 / CooldownTime;
                state.EnvironmentCooldown--;
            }
        }
    }

    // TODO: Delete. It was just a dummy function to prototype.
    public void IncreaseEducationGlobally()
    {
        foreach (StateModel state in stateModels)
        {
            var increment = state.Population * 90 / 100;
            if (state.EducationInvestment < increment)
                state.EducationInvestment = increment;
        }
    }

    static void ExecutePopulationGrowth()
    {
        foreach (StateModel state in stateModels)
            state.Population += Random.Range(state.MininumGrowth, state.MaximumGrowth);
    }

    public void OnClickEducationButton(int stateModelId)
    {
        if (stateModels[stateModelId].EducationCooldown > 0)
            return;

        stateModels[stateModelId].EducationCooldown = CooldownTime;
        EventManager.InvokeInvestmentAreaChanged(stateModels[stateModelId], InvestmentArea.Education);
    }

    public void OnClickHabitationButton(int stateModelId)
    {
        if (stateModels[stateModelId].HabitationCooldown > 0)
            return;

        stateModels[stateModelId].HabitationCooldown = CooldownTime;
        EventManager.InvokeInvestmentAreaChanged(stateModels[stateModelId], InvestmentArea.Habitation);
    }

    public void OnClickHealthButton(int stateModelId)
    {
        if (stateModels[stateModelId].HealthCooldown > 0)
            return;

        stateModels[stateModelId].HealthCooldown = CooldownTime;
        EventManager.InvokeInvestmentAreaChanged(stateModels[stateModelId], InvestmentArea.Health);
    }

    public void OnClickEnvironmentButton(int stateModelId)
    {
        if (stateModels[stateModelId].EnvironmentCooldown > 0)
            return;

        stateModels[stateModelId].EnvironmentCooldown = CooldownTime;
        EventManager.InvokeInvestmentAreaChanged(stateModels[stateModelId], InvestmentArea.Environment);
    }

    public void OnClickCultureButton(int stateModelId)
    {
        if (stateModels[stateModelId].CultureCooldown > 0)
            return;

        stateModels[stateModelId].CultureCooldown = CooldownTime;
        EventManager.InvokeInvestmentAreaChanged(stateModels[stateModelId], InvestmentArea.Culture);
    }

    public void OnClickSecurityButton(int stateModelId)
    {
        if (stateModels[stateModelId].SecurityCooldown > 0)
            return;

        stateModels[stateModelId].SecurityCooldown = CooldownTime;
        EventManager.InvokeInvestmentAreaChanged(stateModels[stateModelId], InvestmentArea.Security);
    }

    public void OnPointerEnterConstruction(int stateModelId)
    {
        App.View.StateInfo.gameObject.SetActive(true);
        App.View.StateInfo.State = stateModels[stateModelId];
    }

    public void OnPointerExitConstruction(int stateModelId)
    {
        App.View.StateInfo.gameObject.SetActive(false);
    }

    public void SpawnHourglass(GameObject parentObject)
    {
        if (parentObject.transform.FindChild(HourglassPrefab.name + "(Clone)") != null)
            return;

        GameObject spawnedHourglass = Instantiate(HourglassPrefab);
        spawnedHourglass.transform.SetParent(parentObject.transform);
        spawnedHourglass.transform.position = parentObject.transform.position + new Vector3(0, 109, 0);
        StartCoroutine(DestroyGameObject(spawnedHourglass, CooldownTime));
    }

    static IEnumerator DestroyGameObject(Object gameObject, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Destroy(gameObject);
    }

    public int TotalPopulation
    {
        get
        {
            int population = 0;
            foreach (StateModel state in stateModels)
            {
                population += state.Population;
            }
            return population;
        }
    }
}