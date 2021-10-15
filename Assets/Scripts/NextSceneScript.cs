using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class nextSceneScript : MonoBehaviour {

	public Button nextBtn;


	public void nextBtnClicked(){
		SceneManager.LoadScene ("DataEntryScene");
	}

//
	void Start()
	{

	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
	}
}
