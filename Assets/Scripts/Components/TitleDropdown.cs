using UnityEngine.UI;

public class TitleDropdown : MvcBehaviour
{
    void OnEnable()
    {
        GlobalStorage.Instance.PlayerTitle = GetComponent<Dropdown>().options[0].text;
    }

    void Start()
    {
        GlobalStorage.Instance.PlayerTitle = GetComponent<Dropdown>().options[0].text;
    }

    public void OnValueChanged(int value)
    {
        GlobalStorage.Instance.PlayerTitle = GetComponent<Dropdown>().options[value].text;
    }
}
