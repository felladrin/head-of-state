public class InvestmentController : MvcBehaviour
{
    InvestmentModel model;
    InvestmentView view;

    void Start()
    {
        model = App.Model.Investment;
        view = App.View.Investment;
    }

    void OnEnable()
    {
        EventManager.OnTick += OnTick;
        EventManager.OnDateDayChanged += OnDateDayChanged;
        EventManager.OnDateMonthChanged += OnDateMonthChanged;
        EventManager.OnInvestmentAreaChanged += OnInvestmentAreaChanged;
    }

    void OnDisable()
    {
        EventManager.OnTick -= OnTick;
        EventManager.OnDateDayChanged -= OnDateDayChanged;
        EventManager.OnDateMonthChanged -= OnDateMonthChanged;
        EventManager.OnInvestmentAreaChanged -= OnInvestmentAreaChanged;
    }

    void OnTick()
    {
        model.BankBalance -= model.BankBalanceReductionPerSecond;
        view.SetBankBalanceNumber(model.BankBalance);
    }

    void OnDateDayChanged()
    {
        model.DomainFund += App.Controller.State.TotalPopulation * model.Tax / 100 * model.TaxMultiplier;
        view.SetDomainFundNumber(model.DomainFund);
    }

    void OnDateMonthChanged()
    {
        model.BankBalance += model.Salary;
        view.SetBankBalanceNumber(model.BankBalance);
    }
    
    void OnInvestmentAreaChanged(StateModel stateModel, InvestmentArea investmentArea)
    {
        model.DomainFund -= model.BuildingUpgradeMultiplier * stateModel.Population;
        view.SetDomainFundNumber(model.DomainFund);
    }

    public void OnClickChangeTaxButton(int value)
    {
        model.Tax += value;
        view.SetTaxNumber(model.Tax);
    }
}
