using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


public class GlobalControl : MonoBehaviour 
{

	public static GlobalControl _instance;
	public static GlobalControl Instance { get { return _instance; } }

	public StudentData studentData = new StudentData();
	public List<string> schoolsList = new List<string>();
	public int schoolIndex;


	void Awake()
	{
		//Application.targetFrameRate = 144;
		if (_instance == null)
		{
			DontDestroyOnLoad(gameObject);
			_instance = this;
		}
//		else if (_instance != this)
//		{
//			Destroy(gameObject);
//		}

	
	}
}