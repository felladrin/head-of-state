public class AlertController : MvcBehaviour
{
    public void OnClickApproveButton()
    {
        App.View.VicePresident.PlayGoOutAnimation();
        HideAlert();
        App.Model.Investment.DomainFund -= App.Model.Alert.Value;
		App.Controller.State.IncreaseEducationGlobally();
        EventManager.InvokeAlertClosed();
    }

    public void OnClickDenyButton()
    {
        App.View.VicePresident.PlayGoOutAnimation();
        HideAlert();
        EventManager.InvokeAlertClosed();
    }

    public void OnClickStealMoneyButton()
    {
        App.View.StealBar.gameObject.SetActive(true);
        App.View.VicePresident.PlayGoOutAnimation();
        HideAlert();
        EventManager.InvokeAlertClosed();
    }

    public void ShowAlert()
    {
        var model = App.Model.Alert;
        model.Generate();

        var view = App.View.Alert;
        view.SetSubject(model.Subject);
        view.SetBody(model.Body);
        view.Enable();
    }

    public void HideAlert()
    {
        App.View.Alert.Disable();
    }
}

