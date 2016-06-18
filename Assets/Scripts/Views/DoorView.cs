using UnityEngine;
using UnityEngine.UI;

public class DoorView : MvcBehaviour
{
    public Image image;
    public Sprite doorOpen;
    public Sprite doorClosed;

    public void SetState(bool open)
    {
        image.sprite = open ? doorOpen : doorClosed;
    }
}