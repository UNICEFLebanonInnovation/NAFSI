using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GenericScript : MonoBehaviour {

	public Button nextButton;

	public void simpleNextBtnClicked(bool manual = false){

		SceneManager.LoadScene (Scenes.getNextScene(SceneManager.GetActiveScene().name,manual));
	}


	// Use this for initialization
	void Start () {

		string genderStr = "";
		if (GlobalControl.Instance!= null) {
			 genderStr = GlobalControl.Instance.studentData.Gender;
		}


		bool gender = false;

		if (genderStr == "Male") {
			gender = true;
		}

		if (SceneManager.GetActiveScene ().name == "ChildIntroScene" || SceneManager.GetActiveScene ().name == "IntroBoyYellowScene" || SceneManager.GetActiveScene ().name == "IntroBoyOrangeScene" || SceneManager.GetActiveScene ().name == "IntroBoyRedScene" || SceneManager.GetActiveScene ().name == "IntroBoyBlueScene" || SceneManager.GetActiveScene ().name == "IntroBoyBrownScene"
			|| SceneManager.GetActiveScene ().name == "IntroGirlYellowScene" || SceneManager.GetActiveScene ().name == "IntroGirlOrangeScene" || SceneManager.GetActiveScene ().name == "IntroGirlRedScene" || SceneManager.GetActiveScene ().name == "IntroGirlBlueScene" || SceneManager.GetActiveScene ().name == "IntroGirlBrownScene") {
			nextButton.interactable = false;
			StartCoroutine (playTitle (gender));
		}

		if (SceneManager.GetActiveScene ().name == "TempratureScene") {
			nextButton.interactable = false;
			StartCoroutine (playTempTitle (gender));
		}	
	}

	IEnumerator playTitle(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateTitle ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		
			AudioHelper.Instance.ActivateSubTitle ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length);
		} else {
			AudioHelper.Instance.ActivateTitleFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);

			AudioHelper.Instance.ActivateSubTitleFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length);
		}
	
		nextButton.interactable = true;
	}

	IEnumerator playTempTitle(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateTitle ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);

		} else {
			AudioHelper.Instance.ActivateTitleFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
