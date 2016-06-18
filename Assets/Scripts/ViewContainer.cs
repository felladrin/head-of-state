using UnityEngine;

public class ViewContainer : MvcBehaviour
{
    [Header("Gameplay Scene Views")]
    public TimeView Time;
    public InvestmentView Investment;
    public DoorView Door;
    public AlertView Alert;
    public StateInfoView StateInfo;
    public InvestmentAreaBarsView InvestmentAreaBars;
    public VicePresidentView VicePresident;
    public StealBarView StealBar;
    public TooltipView Tooltip;

    [Header("Gameplay Scene Views - States")]
    public StateView StateView0;
    public StateView StateView1;
    public StateView StateView2;
    public StateView StateView3;
}