public class DoorController : MvcBehaviour
{
    public void OnClick()
    {
        App.Model.Door.Open = !App.Model.Door.Open;
        App.View.Door.SetState(App.Model.Door.Open);
        
        if (App.Model.Door.Open)
            App.View.VicePresident.PlayComeInAnimation(); // TODO: Create an event for it.
    }
}

