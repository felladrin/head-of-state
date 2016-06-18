using UnityEngine;
using UnityEngine.UI;

public class SpeakerIconView : MonoBehaviour
{
    public Sprite SpeakerOn;
    public Sprite SpeakerOff;

    public void ToggleSpeaker()
    {
        if (GlobalStorage.Instance.GetComponent<AudioSource>().mute)
        {
            GlobalStorage.Instance.GetComponent<AudioSource>().mute = false;
            gameObject.GetComponent<Image>().sprite = SpeakerOn;
        }
        else
        {
            GlobalStorage.Instance.GetComponent<AudioSource>().mute = true;
            gameObject.GetComponent<Image>().sprite = SpeakerOff;
        }
    }
}
