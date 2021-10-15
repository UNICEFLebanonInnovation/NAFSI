using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using ArabicSupport;


public class FixLabelTextCS : MonoBehaviour {

	//public string text;
	public bool tashkeel = true;
	public bool hinduNumbers = true;

	// Use this for initialization
	void Start () {
		Text dropdownText = gameObject.GetComponent<Text> ();
		string text = dropdownText.text;
		dropdownText.text = ArabicFixer.Fix(text, tashkeel, hinduNumbers);
	
	}

	// Update is called once per frame
	void Update () {

	}
}
