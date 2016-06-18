using UnityEngine;
using UnityEngine.UI;

public class VicePresidentView : MvcBehaviour
{
    Animation anim;
    Image image;

    void Start()
    {
        anim = GetComponent<Animation>();
        image = GetComponent<Image>();
    }

    public void Show()
    {
        image.enabled = true;
    }
    
    public void Hide()
    {
        image.enabled = false;
    }

    public void PlayComeInAnimation()
    {
        Show();
        anim.clip = anim.GetClip("VicePresidentComeIn");
        anim.Play();
    }

    public void PlayGoOutAnimation()
    {
        anim.clip = anim.GetClip("VicePresidentGoOut");
        anim.Play();
    }

    void NotifyVicePresidentHasArrived()
    {
        // TODO: Create an event for it.
        App.Controller.Alert.ShowAlert();
    }

    void NotifyVicePresidentHasGone()
    {
        // TODO: Create an event for it.
        // App.Controller.Door.OnClick();
        Hide();
    }
}

