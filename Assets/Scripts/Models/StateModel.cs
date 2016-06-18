using UnityEngine;

public class StateModel : MvcBehaviour
{
    [SerializeField]
    [Tooltip("")]
    int population = 1000;

    [SerializeField]
    [Tooltip("")]
    int healthInvestment = 500;

    [SerializeField]
    [Tooltip("")]
    int educationInvestment = 500;

    [SerializeField]
    [Tooltip("")]
    int securityInvestment = 500;

    [SerializeField]
    [Tooltip("")]
    int cultureInvestment = 500;

    [SerializeField]
    [Tooltip("")]
    int habitationInvestment = 500;

    [SerializeField]
    [Tooltip("")]
    int environmentInvestment = 500;

    [SerializeField]
    [Tooltip("")]
    int mininumGrowth = -100;

    [SerializeField]
    [Tooltip("")]
    int maximumGrowth = 500;

    [SerializeField]
    [Tooltip("")]
    int healthCooldown;

    [SerializeField]
    [Tooltip("")]
    int securityCooldown;

    [SerializeField]
    [Tooltip("")]
    int educationCooldown;

    [SerializeField]
    [Tooltip("")]
    int cultureCooldown;

    [SerializeField]
    [Tooltip("")]
    int habitationCooldown;

    [SerializeField]
    [Tooltip("")]
    int environmentCooldown;

    [SerializeField]
    [Tooltip("")]
    string stateName;

    public int Population
    {
        get
        {
            return population;
        }
        set
        {
            population = Mathf.Clamp(value, 0, 100000000);
        }
    }

    public int HealthInvestment
    {
        get
        {
            return healthInvestment;
        }
        set
        {
            healthInvestment = value;
        }
    }

    public int EducationInvestment
    {
        get
        {
            return educationInvestment;
        }
        set
        {
            educationInvestment = value;
        }
    }

    public int SecurityInvestment
    {
        get
        {
            return securityInvestment;
        }
        set
        {
            securityInvestment = value;
        }
    }

    public int CultureInvestment
    {
        get
        {
            return cultureInvestment;
        }
        set
        {
            cultureInvestment = value;
        }
    }

    public int HabitationInvestment
    {
        get
        {
            return habitationInvestment;
        }
        set
        {
            habitationInvestment = value;
        }
    }

    public int EnvironmentInvestment
    {
        get
        {
            return environmentInvestment;
        }
        set
        {
            environmentInvestment = value;
        }
    }

    public int MininumGrowth
    {
        get
        {
            return mininumGrowth;
        }
    }

    public int MaximumGrowth
    {
        get
        {
            return maximumGrowth;
        }
    }

    public string StateName
    {
        get
        {
            return stateName;
        }
        set
        {
            stateName = value;
        }
    }
    public int HealthCooldown
    {
        get
        {
            return healthCooldown;
        }
        set
        {
            healthCooldown = value;
        }
    }

    public int SecurityCooldown
    {
        get
        {
            return securityCooldown;
        }
        set
        {
            securityCooldown = value;
        }
    }

    public int EducationCooldown
    {
        get
        {
            return educationCooldown;
        }
        set
        {
            educationCooldown = value;
        }
    }

    public int CultureCooldown
    {
        get
        {
            return cultureCooldown;
        }
        set
        {
            cultureCooldown = value;
        }
    }

    public int HabitationCooldown
    {
        get
        {
            return habitationCooldown;
        }
        set
        {
            habitationCooldown = value;
        }
    }

    public int EnvironmentCooldown
    {
        get
        {
            return environmentCooldown;
        }
        set
        {
            environmentCooldown = value;
        }
    }

    public float Health { get { return percentageOverPopulation(healthInvestment); } }

    public float Education { get { return percentageOverPopulation(educationInvestment); } }

    public float Security { get { return percentageOverPopulation(securityInvestment); } }

    public float Culture { get { return percentageOverPopulation(cultureInvestment); } }

    public float Habitation { get { return percentageOverPopulation(habitationInvestment); } }

    public float Environment { get { return percentageOverPopulation(environmentInvestment); } }

    float percentageOverPopulation(float investment)
    {
        float percentage = investment / population;
        return Mathf.Clamp(percentage, 0, 1);
    }
}