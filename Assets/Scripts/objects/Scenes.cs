using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Scenes  {



	public static string getNextScene(string currentScene, bool secondOption)
	{

		string genderStr = "";
		if (GlobalControl.Instance!= null) {
			genderStr = GlobalControl.Instance.studentData.Gender;
		}
		bool gender = false;
		if (genderStr == "Male") {
			gender = true;
		}



		bool start = true;

		if (currentScene == "IntroScene")
			return "DataEntryScene";
		if (currentScene == "DataEntryScene" && !secondOption)
			return "ChildIntroScene";
		if (currentScene == "DataEntryScene" && secondOption)
			return "ManualEntryScene";
		if (currentScene == "ManualEntryScene")
			return "ChildIntroScene";
		if (currentScene == "ChildIntroScene")
			return "TempratureScene";
		if (currentScene == "TempratureScene" && gender && start)
			return "IntroBoyYellowScene";
		if (currentScene == "IntroBoyYellowScene")
			return "Q1BoyYellowScene";
		if (currentScene == "Q1BoyYellowScene")
			return "Q2BoyYellowScene";
		if (currentScene == "Q2BoyYellowScene")
			return "IntroBoyOrangeScene";
		if (currentScene == "IntroBoyOrangeScene") {
			Debug.Log ("543");
			return "Q1BoyOrangeScene";
		}
		if (currentScene == "Q1BoyOrangeScene")
			return "Q2BoyOrangeScene";
		if (currentScene == "Q2BoyOrangeScene")
			return "Q3BoyOrangeScene";
		if (currentScene == "Q3BoyOrangeScene")
			return "IntroBoyRedScene";
		if (currentScene == "IntroBoyRedScene")
			return "Q1BoyRedScene";
		if (currentScene == "Q1BoyRedScene")
			return "Q2BoyRedScene";
		if (currentScene == "Q2BoyRedScene")
			return "Q3BoyRedScene";
		if (currentScene == "Q3BoyRedScene")
			return "IntroBoyBlueScene";
		if (currentScene == "IntroBoyBlueScene")
			return "Q1BoyBlueScene";
		if (currentScene == "Q1BoyBlueScene")
			return "Q2BoyBlueScene";
		if (currentScene == "Q2BoyBlueScene")
			return "Q3BoyBlueScene";
		if (currentScene == "Q3BoyBlueScene")
			return "IntroBoyBrownScene";
		if (currentScene == "IntroBoyBrownScene")
			return "Q1BoyBrownScene";
		if (currentScene == "Q1BoyBrownScene")
			return "Q2BoyBrownScene";	
		if (currentScene == "Q2BoyBrownScene")
			return "DataEntryScene";


		if (currentScene == "TempratureScene" && !gender )
			return "IntroGirlYellowScene";
		if (currentScene == "IntroGirlYellowScene")
			return "Q1GirlYellowScene";
		if (currentScene == "Q1GirlYellowScene")
			return "Q2GirlYellowScene";
		if (currentScene == "Q2GirlYellowScene")
			return "IntroGirlOrangeScene";
		if (currentScene == "IntroGirlOrangeScene")
			return "Q1GirlOrangeScene";
		if (currentScene == "Q1GirlOrangeScene")
			return "Q2GirlOrangeScene";
		if (currentScene == "Q2GirlOrangeScene")
			return "Q3GirlOrangeScene";
		if (currentScene == "Q3GirlOrangeScene")
			return "IntroGirlRedScene";
		if (currentScene == "IntroGirlRedScene")
			return "Q1GirlRedScene";
		if (currentScene == "Q1GirlRedScene")
			return "Q2GirlRedScene";
		if (currentScene == "Q2GirlRedScene")
			return "Q3GirlRedScene";
		if (currentScene == "Q3GirlRedScene")
			return "IntroGirlBlueScene";
		if (currentScene == "IntroGirlBlueScene")
			return "Q1GirlBlueScene";
		if (currentScene == "Q1GirlBlueScene")
			return "Q2GirlBlueScene";
		if (currentScene == "Q2GirlBlueScene")
			return "Q3GirlBlueScene";
		if (currentScene == "Q3GirlBlueScene")
			return "IntroGirlBrownScene";		
		if (currentScene == "IntroGirlBrownScene")
			return "Q1GirlBrownScene";
		if (currentScene == "Q1GirlBrownScene")
			return "Q2GirlBrownScene";
		if (currentScene == "Q2GirlBrownScene")
			return "DataEntryScene";


		return null;
	}


	public static string setAnswer(string currentScene, int answer)
	{


		if (currentScene == "TempratureScene")
			GlobalControl.Instance.studentData.FeelingBefore = answer;

		if (currentScene == "Q1BoyYellowScene")
			GlobalControl.Instance.studentData.A1 = answer;
		if (currentScene == "Q2BoyYellowScene")
			GlobalControl.Instance.studentData.A2 = answer;


		if (currentScene == "Q1BoyOrangeScene")
			GlobalControl.Instance.studentData.A3 = answer;
		if (currentScene == "Q2BoyOrangeScene")
			GlobalControl.Instance.studentData.A4 = answer;
		if (currentScene == "Q3BoyOrangeScene")
			GlobalControl.Instance.studentData.A5 = answer;



		if (currentScene == "Q1BoyRedScene")
			GlobalControl.Instance.studentData.A6 = answer;
		if (currentScene == "Q2BoyRedScene")
			GlobalControl.Instance.studentData.A7 = answer;
		if (currentScene == "Q3BoyRedScene")
			GlobalControl.Instance.studentData.A8 = answer;



		if (currentScene == "Q1BoyBlueScene")
			GlobalControl.Instance.studentData.A9 = answer;
		if (currentScene == "Q2BoyBlueScene")
			GlobalControl.Instance.studentData.A10 = answer;
		if (currentScene == "Q3BoyBlueScene")
			GlobalControl.Instance.studentData.A11 = answer;


		if (currentScene == "Q1BoyBrownScene")
			GlobalControl.Instance.studentData.A12 = answer;	
		if (currentScene == "Q2BoyBrownScene")
			GlobalControl.Instance.studentData.A13 = answer;


		if (currentScene == "Q1GirlYellowScene")
			GlobalControl.Instance.studentData.A1 = answer;
		if (currentScene == "Q2GirlYellowScene")
			GlobalControl.Instance.studentData.A2 = answer;

		if (currentScene == "Q1GirlOrangeScene")
			GlobalControl.Instance.studentData.A3 = answer;
		if (currentScene == "Q2GirlOrangeScene")
			GlobalControl.Instance.studentData.A4 = answer;
		if (currentScene == "Q3GirlOrangeScene")
			GlobalControl.Instance.studentData.A5 = answer;


		if (currentScene == "Q1GirlRedScene")
			GlobalControl.Instance.studentData.A6 = answer;
		if (currentScene == "Q2GirlRedScene")
			GlobalControl.Instance.studentData.A7 = answer;
		if (currentScene == "Q3GirlRedScene")
			GlobalControl.Instance.studentData.A8 = answer;


		if (currentScene == "Q1GirlBlueScene")
			GlobalControl.Instance.studentData.A9 = answer;
		if (currentScene == "Q2GirlBlueScene")
			GlobalControl.Instance.studentData.A10 = answer;
		if (currentScene == "Q3GirlBlueScene")
			GlobalControl.Instance.studentData.A11 = answer;	


		if (currentScene == "Q1GirlBrownScene")
			GlobalControl.Instance.studentData.A12 = answer;
		if (currentScene == "Q2GirlBrownScene")
			GlobalControl.Instance.studentData.A13 = answer;


		return null;
	}



//	public string nextScene;
//
//
//	public static Scenes CreateFromJSON(string jsonString)
//		{
//		return JsonUtility.FromJson<Scenes>(jsonString);
//		}


}
