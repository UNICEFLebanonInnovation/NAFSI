using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){

		string genderStr = GlobalControl.Instance.studentData.Gender;
		bool gender = false;
		if (genderStr == "Male") {
			gender = true;
		}
			
		Button nextBtn = GameObject.Find ("NextBtn").GetComponent<Button> ();
		nextBtn.interactable = true;


		//SpriteRenderer thermo = GameObject.Find ("thermo").GetComponent<SpriteRenderer> ();
		if (this.gameObject.name == "face1") {
			//thermo.sprite = (Sprite)Resources.Load ("thermo-1", typeof(Sprite));
			SpriteRenderer selected = GameObject.Find ("face1/bubble-white").GetComponent<SpriteRenderer> ();  
			selected.sprite = (Sprite)Resources.Load ("selected-bubble", typeof(Sprite));

			SpriteRenderer unselect1 = GameObject.Find ("face2/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect1.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect2 = GameObject.Find ("face3/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect2.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect3 = GameObject.Find ("face4/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect3.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));


			StartCoroutine (playAnswer1(gender));
		} else if (this.gameObject.name == "face2") {

			SpriteRenderer selected = GameObject.Find ("face2/bubble-white").GetComponent<SpriteRenderer> ();  
			selected.sprite = (Sprite)Resources.Load ("selected-bubble", typeof(Sprite));

			SpriteRenderer unselect1 = GameObject.Find ("face1/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect1.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect2 = GameObject.Find ("face3/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect2.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect3 = GameObject.Find ("face4/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect3.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));


			//	thermo.sprite = (Sprite)Resources.Load ("thermo-2", typeof(Sprite));
			StartCoroutine (playAnswer2(gender));
		} else if (this.gameObject.name == "face3") {

			SpriteRenderer selected = GameObject.Find ("face3/bubble-white").GetComponent<SpriteRenderer> ();  
			selected.sprite = (Sprite)Resources.Load ("selected-bubble", typeof(Sprite));

			SpriteRenderer unselect1 = GameObject.Find ("face1/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect1.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect2 = GameObject.Find ("face2/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect2.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect3 = GameObject.Find ("face4/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect3.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));


			//	thermo.sprite = (Sprite)Resources.Load ("thermo-3", typeof(Sprite));
			StartCoroutine (playAnswer3(gender));
		} else if (this.gameObject.name == "face4") {
			//	thermo.sprite = (Sprite)Resources.Load ("thermo-4", typeof(Sprite));

			SpriteRenderer selected = GameObject.Find ("face4/bubble-white").GetComponent<SpriteRenderer> ();  
			selected.sprite = (Sprite)Resources.Load ("selected-bubble", typeof(Sprite));

			SpriteRenderer unselect1 = GameObject.Find ("face1/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect1.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect2 = GameObject.Find ("face2/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect2.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));
			SpriteRenderer unselect3 = GameObject.Find ("face3/bubble-white").GetComponent<SpriteRenderer> (); 
			unselect3.sprite = (Sprite)Resources.Load ("bubble-white", typeof(Sprite));

			StartCoroutine (playAnswer4(gender));
		}

	}


	IEnumerator playAnswer1(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer1Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer1SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}


	IEnumerator playAnswer2(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer2Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer2SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}

	IEnumerator playAnswer3(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer3Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer3SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}

	IEnumerator playAnswer4(bool isMale){
		if (isMale) {
			AudioHelper.Instance.ActivateAnswer4Sound ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		} else {
			AudioHelper.Instance.ActivateAnswer4SoundFemale ();
			yield return new WaitForSeconds (AudioHelper.Instance.audioSource.clip.length+1);
		}
	}

}
