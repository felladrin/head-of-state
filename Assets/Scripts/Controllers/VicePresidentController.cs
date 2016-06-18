public class VicePresidentController : MvcBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("ComeIn", 5, 30);
	}

	void ComeIn() {
		App.View.VicePresident.PlayComeInAnimation();
	}
}
