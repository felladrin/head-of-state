using UnityEngine;

public class AlertModel : MvcBehaviour
{
    
    [Tooltip("Area affected.")]
    public InvestmentArea area;
    
    [Tooltip("")]
    public int baseValue = 1000;
    
    [Tooltip("")]
    public bool positiveEffect = true;
    
    [Tooltip("")]
    public string Subject;
    
    [Tooltip("")]
    public string Body;
    
    [Tooltip("")]
    public InvestmentArea Area;
    
    [Tooltip("")]
    public int Value;
    
    public void Generate()
    {
        // TODO: Generate random alert;
        Subject = "Education Alert";
        Body = "Due to the lack of investment in education some schools are about to close because there's not enough money keep them. Teachers are on strike. Students are without class for too long. We must quickly invest in education before the worst happens.\n\nInvesment value: 560,000\n\nDo you approve this investment?";
        Area = InvestmentArea.Education;
        Value = 560000;
    }
}