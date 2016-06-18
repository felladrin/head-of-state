public class PlayerNameInputField : MvcBehaviour
{
    public void OnEndEdit(string value)
    {
        GlobalStorage.Instance.PlayerName = value;
    }
}