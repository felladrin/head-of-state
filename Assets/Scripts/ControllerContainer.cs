using UnityEngine;

public class ControllerContainer : MvcBehaviour
{
    [Header("Gameplay Scene Controllers")]
    public TimeController Time;
    public DoorController Door;
    public AlertController Alert;
    public InvestmentAreaBarsController InvestmentAreaBars;
    public StateController State;
    public StealBarController StealBar;
}