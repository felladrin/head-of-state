using UnityEngine;

public class InvestmentModel : MvcBehaviour
{
    [SerializeField]
    [Tooltip("Current balance of bank account.")]
    int bankBalance = 10000;
    
    [SerializeField]
    [Tooltip("How much is increased on bank balance per month.")]
    int salary = 10000;
    
    [SerializeField]
    [Tooltip("Percentage of the tax.")]
    int tax = 20;
    
    [SerializeField]
    [Tooltip("Used to balance the tax calculation.")]
    int taxMultiplier = 5;
    
    [SerializeField]
    [Tooltip("Current balance of domain fund.")]
    int domainFund = 10000000;
    
    [SerializeField]
    [Tooltip("Used to balance how much is spend each time the player clicks to upgrade a building.")]
    int buildingUpgradeMultiplier = 5;
    
    [SerializeField]
    [Tooltip("How much is debited from bank balance per month.")]
    int bankBalanceMonthlyUsage = 10000;

    public int BankBalanceReductionPerDay
    {
        get
        {
            return bankBalanceMonthlyUsage / App.Model.Time.DaysPerMonth;
        }
    }

    public int BankBalanceReductionPerSecond
    {
        get
        {
            return bankBalanceMonthlyUsage / App.Model.Time.DaysPerMonth / App.Model.Time.SecondsPerDay;
        }
    }

    public int BuildingUpgradeMultiplier
    {
        get
        {
            return buildingUpgradeMultiplier;
        }
    }

    public int BankBalance
    {
        get
        {
            return bankBalance;
        }
        set
        {
            bankBalance = value;
            // TODO: Fire events when account is too hight or too low.
        }
    }

    public int DomainFund
    {
        get
        {
            return domainFund;
        }
        set
        {
            domainFund = value;
            // TODO: Fire events when account is too hight or too low.
        }
    }

    public int Salary
    {
        get
        {
            return salary;
        }
    }

    public int Tax
    {
        get
        {
            return tax;
        }
        set
        {
            tax = Mathf.Clamp(value, 20, 60);
        }
    }
    
    public int TaxMultiplier
    {
        get
        {
            return taxMultiplier;
        }
    }
}