using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;

public class ArabicInputFieldScript : MonoBehaviour {

	// Use this for initialization
	public Text Label;

	void Start() {
		InputField inputField = gameObject.GetComponent<InputField> ();
		inputField.onValueChanged.AddListener(delegate {
			myInputValueChangedHandler();
		});
	}
	void Destroy() {
		InputField inputField = gameObject.GetComponent<InputField> ();
		inputField.onValueChanged.RemoveAllListeners();
	}

	private void myInputValueChangedHandler() {
		Debug.Log("selected: "+ Label.text);
		Label.text = ArabicFixer.Fix(Label.text, true, true);
	}	


		
}
