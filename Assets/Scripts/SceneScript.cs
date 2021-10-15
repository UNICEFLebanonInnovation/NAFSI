using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{

	//public Button nextBtn;


	public void simpleNextBtnClicked(){

		SceneManager.LoadScene (Scenes.getNextScene(SceneManager.GetActiveScene().name,false));
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

