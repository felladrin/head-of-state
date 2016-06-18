using UnityEngine.UI;

public class StateInfoView : MvcBehaviour
{
    public StateModel State;
    public Text StateName;
    public Text PopulationNumber;

    void Update()
    {
        if (State == null)
            return;

        StateName.text = State.StateName;
        PopulationNumber.text = State.Population.ToString();
    }

    public void SetStateName(string name)
    {
        StateName.text = name;
    }

    public void SetPopulationNumber(int population)
    {
        PopulationNumber.text = population.ToString();
    }
}

