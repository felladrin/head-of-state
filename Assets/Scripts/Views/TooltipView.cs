using UnityEngine;
using UnityEngine.UI;

public class TooltipView : MonoBehaviour {
	public int DelayToHide = 3;
	Text textComponent;
	int delayCountdown;

	void Awake () {
		textComponent = GetComponent<Text>();
	}

	void OnEnable()
    {
        EventManager.OnTick += OnTick;
    }

    void OnDisable()
    {
        EventManager.OnTick -= OnTick;
    }

	public void Display (string str)
	{
		gameObject.SetActive(true);
		textComponent.text = str;
		delayCountdown = DelayToHide;
	}

	public void Hide ()
	{
		gameObject.SetActive(false);
	}

	void OnTick() {
		if (delayCountdown > 0)
			delayCountdown--;
		else
			Hide();
	}
}
