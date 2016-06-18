using UnityEngine.UI;
public class AlertView : MvcBehaviour
{
    public Text Subject;
    public Text Body;
    
    public void Enable()
    {
        gameObject.SetActive(true);
    }
    
    public void Disable()
    {
        gameObject.SetActive(false);
    }
    
    public void SetSubject(string value)
    {
        Subject.text = value;
    }
    
    public void SetBody(string value)
    {
        Body.text = value;
    }
}

