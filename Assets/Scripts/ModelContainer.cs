using UnityEngine;

public class ModelContainer : MvcBehaviour
{
    [Header("Gameplay Scene Models")]
    public TimeModel Time;
    public InvestmentModel Investment;
    public DoorModel Door;
    public AlertModel Alert;
    public StealBarModel StealBar;

    [Header("Gameplay Scene Models - States")]
    public StateModel StateModel0;
    public StateModel StateModel1;
    public StateModel StateModel2;
    public StateModel StateModel3;
}