using UnityEngine;
using UnityEngine.UI;

public class DomainNameOnTablet : MonoBehaviour {

	void Start () {
		GetComponent<Text>().text = GlobalStorage.Instance.DomainName + " Stats";
	}
}
