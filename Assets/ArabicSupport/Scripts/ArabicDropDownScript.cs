using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;


public class ArabicDropDownScript : MonoBehaviour {

	public Text Label;

	void Start() {
		Dropdown myDropdown = gameObject.GetComponent<Dropdown> ();
		myDropdown.onValueChanged.AddListener(delegate {
			myDropdownValueChangedHandler(myDropdown);
		});
	}
	void Destroy() {
		Dropdown myDropdown = gameObject.GetComponent<Dropdown> ();
		myDropdown.onValueChanged.RemoveAllListeners();
	}

	private void myDropdownValueChangedHandler(Dropdown target) {
		//Debug.Log("selected: "+Label.text);
		Label.text = ArabicFixer.Fix(Label.text, true, true);
	}

	public void SetDropdownIndex(int index) {
		Dropdown myDropdown = gameObject.GetComponent<Dropdown> ();
		myDropdown.value = index;
	}
}
