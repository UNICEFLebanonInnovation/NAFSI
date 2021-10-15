using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeelingButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){


		string genderStr = "";
		if (GlobalControl.Instance!= null) {
			genderStr = GlobalControl.Instance.studentData.Gender;
		}
		bool gender = false;
		if (genderStr == "Male") {
			gender = true;
		}


		Button nextBtn = GameObject.Find ("NextBtn").GetComponent<Button> ();
		nextBtn.interactable = true;

		SpriteRenderer thermo = GameObject.Find ("thermo").GetComponent<SpriteRenderer> ();
		if (this.gameObject.name == "feeling1") {
			thermo.sprite = (Sprite)Resources.Load ("thermo-1", typeof(Sprite));
			StartCoroutine (playFeeling1(gender));
			GlobalControl.Instance.studentData.FeelingBefore = 1;
		} else if (this.gameObject.name == "feeling2") {
			thermo.sprite = (Sprite)Resources.Load ("thermo-2", typeof(Sprite));
			StartCoroutine (playFeeling2(gender));
			GlobalControl.Instance.studentData.FeelingBefore = 2;
		} else if (this.gameObject.name == "feeling3") {
			thermo.sprite = (Sprite)Resources.Load ("thermo-3", typeof(Sprite));
			StartCoroutine (playFeeling3(gender));
			GlobalControl.Instance.studentData.FeelingBefore = 3;
		} else if (this.gameObject.name == "feeling4") {
			thermo.sprite = (Sprite)Resources.Load ("thermo-4", typeof(Sprite));
			StartCoroutine (playFeeling4(gender));
			GlobalControl.Instance.studentData.FeelingBefore = 4;
		}

	}


	IEnumerator playFeeling1(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer1Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer1SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}


	IEnumerator playFeeling2(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer2Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer2SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}

	IEnumerator playFeeling3(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer3Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer3SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}

	IEnumerator playFeeling4(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer4Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer4SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}

}
