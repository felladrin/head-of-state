using UnityEngine.UI;

public class InvestmentView : MvcBehaviour
{
    public Text BankBalanceNumber, DomainFundNumber, TaxNumber;

    public void SetBankBalanceNumber(int value)
    {
        BankBalanceNumber.text = value.ToString("N0");
    }

    public void SetDomainFundNumber(int value)
    {
        DomainFundNumber.text = value.ToString("N0");
    }

    public void SetTaxNumber(int value)
    {
        TaxNumber.text = value.ToString("N0");
    }
}