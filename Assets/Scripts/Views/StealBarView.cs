using UnityEngine;
using UnityEngine.UI;

public class StealBarView : MvcBehaviour {
	public Image RightSide;
	public Image LeftSide;

	public Text ClickText;
	
	StealBarModel model;
	
	// Use this for initialization
	void Start () {
		RightSide.fillAmount = 0;
		LeftSide.fillAmount = 0;
		model = App.Model.StealBar;
	}
	
	// Update is called once per frame
	void Update () {
		var fillValue = Mathf.PingPong(Time.time * model.Speed, 1.2F);
		
		RightSide.fillAmount = fillValue;
		LeftSide.fillAmount = fillValue;
		
		model.RightTime = fillValue > 0.9;
		
		if (model.RightTime)
		{
			RightSide.color = model.RightTimeColor;
			LeftSide.color = model.RightTimeColor;
			ClickText.enabled = true;
		}
		else
		{
			RightSide.color = model.WrongTimeColor;
			LeftSide.color = model.WrongTimeColor;
			ClickText.enabled = false;
		}
	}
}
