using UnityEngine;

public class GenreDropdown : MvcBehaviour
{
    public GameObject maleTitleDropdown;
    public GameObject femaleTitleDropdown;

    public void OnValueChanged(int value)
    {
        GlobalStorage.Instance.PlayerGender = (HumanGender)value;
        maleTitleDropdown.SetActive(!maleTitleDropdown.activeInHierarchy);
        femaleTitleDropdown.SetActive(!femaleTitleDropdown.activeInHierarchy);
    }
}
