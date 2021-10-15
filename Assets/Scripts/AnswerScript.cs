using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	
using UnityEngine.SceneManagement;

public class AnswerScript : MonoBehaviour {



	public void NextBtnClicked(bool manual = false){
		SceneManager.LoadScene (Scenes.getNextScene(SceneManager.GetActiveScene().name,manual));
	}



	// Use this for initialization
	void Start () {

		string genderStr = GlobalControl.Instance.studentData.Gender;
		bool gender = false;
		if (genderStr == "Male") {
			gender = true;
		}

		Button nextButton = GameObject.Find ("NextBtn").GetComponent<Button>();
		nextButton.onClick.AddListener (() => NextBtnClicked(false));
		nextButton.interactable = false;
		StartCoroutine (playQuestion (gender));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator playQuestion(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateTitle ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);

		} else {
			AudioHelper.Instance.ActivateTitleFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}

	}
}
