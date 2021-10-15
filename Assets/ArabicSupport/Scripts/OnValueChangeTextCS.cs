using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;

public class OnValueChangeTextCS : MonoBehaviour {

	//public bool tashkeel = true;
	//public bool hinduNumbers = true;



	public void ChangeText(Dropdown target){
		string text = gameObject.GetComponent<Text> ().text;
		gameObject.GetComponent<Text> ().text = ArabicFixer.Fix (text, false, false );
	}


}
