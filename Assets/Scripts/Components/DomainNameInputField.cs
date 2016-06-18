public class DomainNameInputField : MvcBehaviour
{
    public void OnEndEdit(string value)
    {
        GlobalStorage.Instance.DomainName = value;
    }
}