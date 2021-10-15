using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.Linq;





public class DataEntryScene : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//
//
//	}

	void Destroy() {
		Dropdown myDropdown = gameObject.GetComponent<Dropdown> ();
		myDropdown.onValueChanged.RemoveAllListeners();
	}

	private void myDropdownValueChangedHandler(Dropdown target) {
		//Debug.Log("selected: "+ arr.ToArray()[target.value]);
		dropdown3.ClearOptions ();
		dropdown2.ClearOptions ();
		StartCoroutine(getKids());
	}

	public void SetDropdownIndex(int index) {
		Dropdown myDropdown = gameObject.GetComponent<Dropdown> ();
		myDropdown.value = index;
	}

	private void myDropdownValueChangedHandler3(Dropdown target) {
		//Debug.Log("selected: "+ arr3.ToArray()[target.value]);


		GlobalControl.Instance.studentData = (StudentData)grades [grade] [target.value];
		Debug.Log (GlobalControl.Instance.studentData.Gender);
		//Debug.Log (GlobalControl.Instance.studentData.ToString());


		//Label.text = ArabicFixer.Fix(target.text, true, true);
	}

	private void myDropdownValueChangedHandler2(Dropdown target) {
		Debug.Log("selected: "+ arr2.ToArray()[target.value]);

		 grade = arr2.ToArray () [target.value];
		dropdown3.ClearOptions ();

		List<string> tempStudents = new List<string>();

		for(int i=0; i < grades[grade].Count; i++){

			tempStudents.Add(grades[grade][i].Name);
		}

		dropdown3.AddOptions (tempStudents);
		GlobalControl.Instance.studentData = (StudentData)grades [grade] [0];
		Debug.Log (GlobalControl.Instance.studentData.Gender);
		//Label.text = ArabicFixer.Fix(target.text, true, true);
	}


	// Update is called once per frame
	void Update () {
		
	}

	public Dropdown dropdown;
	public Dropdown dropdown2;
	public Dropdown dropdown3;
	public string grade;
	//List<string> arr;
	List<string> arr2;
	List<string> arr3;
	string selection;
	JsonData jsonvale;
	Dictionary<string, List<StudentData>> grades;

	JsonData jsonvale3;


	IEnumerator Start()
	{

	
		dropdown.onValueChanged.AddListener(delegate {
			myDropdownValueChangedHandler(dropdown);
		});


		dropdown2.onValueChanged.AddListener(delegate {
			myDropdownValueChangedHandler2(dropdown2);
		});

		dropdown3.onValueChanged.AddListener(delegate {
			myDropdownValueChangedHandler3(dropdown3);
		});


	//	var www = new WWWForm();
		var headers = new Dictionary<string,string>();
		headers.Add("Content-Type", "application/json");
		headers.Add("Authorization", "Token fb547117f0fb75a6a57692e45d148d6e86524a6c");
		string url = "https://leb-container-test.azurewebsites.net/api/schools/";
		WWW www = new WWW(url, null, headers);
		yield return www;
		if (www != null)
		{
			Processjson(www.text);
			//Debug.Log(www.text);
			//Debug.Log ("DATA");
		}
		else
		{

		}        
	}


	private void Processjson(string jsonString)
	{
		jsonvale = JsonMapper.ToObject("{'arr':"+jsonString+"}");

		//parseJSON parsejson;
		//parsejson = new parseJSON();
		//parsejson.title = jsonvale["title"].ToString();
		//parsejson.id = jsonvale["ID"].ToString();
		List<string> arr = new List<string>();

		//	parsejson.but_title = new ArrayList ();
		//	parsejson.but_image = new ArrayList ();
		dropdown.ClearOptions();
		arr.Add ("Select School");
		for(int i = 0; i<jsonvale["arr"].Count; i++)
		{
			arr.Add(jsonvale["arr"][i]["id"].ToString());
		}    

	//	Debug.Log (arr.ToString ());
		GlobalControl.Instance.schoolsList = arr;
		dropdown.AddOptions (GlobalControl.Instance.schoolsList);
	}


	private void Processjson2(string jsonString)
	{
		jsonvale3 = JsonMapper.ToObject("{'arr':"+jsonString+"}");

		arr3 = new List<string>();

		dropdown2.ClearOptions();
		dropdown3.ClearOptions();
		arr3.Add ("Select Student");


		  grades = new Dictionary<string, List<StudentData>>();


		for (int i = 0; i < jsonvale3["arr"].Count; i++) 
		{

			if (grades.ContainsKey (jsonvale3 ["arr"] [i] ["grade"].ToString())) {

				List<StudentData> students = (List<StudentData>)grades[jsonvale3 ["arr"] [i]["grade"].ToString()];

				StudentData student = new StudentData ();
				student.Name = jsonvale3 ["arr"] [i] ["student_first_name"].ToString () + " " + jsonvale3 ["arr"] [i] ["student_last_name"].ToString ();
				student.ID = jsonvale3 ["arr"] [i] ["student_id"].ToString ();
				student.Grade= jsonvale3 ["arr"] [i] ["grade"].ToString ();
				student.Nationality= jsonvale3 ["arr"] [i] ["student_nationality"].ToString ();
				student.School= jsonvale3 ["arr"] [i] ["registered_in_school"].ToString ();
				student.Gender  = jsonvale3 ["arr"] [i] ["student_sex"].ToString ();

				students.Add (student);
				grades.Add( jsonvale3 ["arr"] [i] ["grade"].ToString(), students);
				
			} else {

				List<StudentData> students = new List<StudentData>();

				StudentData student = new StudentData ();
				student.Name = jsonvale3 ["arr"] [i] ["student_first_name"].ToString () + " " + jsonvale3 ["arr"] [i] ["student_last_name"].ToString ();
				student.ID = jsonvale3 ["arr"] [i] ["student_id"].ToString ();
				student.Grade= jsonvale3 ["arr"] [i] ["grade"].ToString ();
				student.Nationality= jsonvale3 ["arr"] [i] ["student_nationality"].ToString ();
				student.School= jsonvale3 ["arr"] [i] ["registered_in_school"].ToString ();
				student.Gender  = jsonvale3 ["arr"] [i] ["student_sex"].ToString ();

				students.Add (student);
				grades.Add( jsonvale3 ["arr"] [i] ["grade"].ToString(), students);

			}


			//grades.Add(jsonvale3["arr"][i]["grade"],)
		}


		arr2 = grades.Keys.ToList ();
		dropdown2.AddOptions (arr2);

		List<string> tempStudents = new List<string>();

		for(int i=0; i < grades["1"].Count; i++){
			tempStudents.Add(grades["1"][i].Name);
		}

		//arr3 = grades["1"];
		dropdown3.AddOptions (tempStudents);
		GlobalControl.Instance.studentData = (StudentData)grades ["1"] [0];
		Debug.Log (GlobalControl.Instance.studentData.Gender);

//		for(int i = 0; i<jsonvale3["arr"].Count; i++)
//		{
//
//
//			arr3.Add(jsonvale3["arr"][i]["student_first_name"].ToString() +" "+ jsonvale3["arr"][i]["student_last_name"].ToString()+"-");
//		}    

	//	dropdown3.AddOptions (arr3);
	}







//	private void Processjson3(string jsonString)
//	{
//		jsonvale3 = JsonMapper.ToObject("{'arr':"+jsonString+"}");
//
//		//parseJSON parsejson;
//		//parsejson = new parseJSON();
//		//parsejson.title = jsonvale["title"].ToString();
//		//parsejson.id = jsonvale["ID"].ToString();
//		arr3 = new List<string>();
//
//		//	parsejson.but_title = new ArrayList ();
//		//	parsejson.but_image = new ArrayList ();
//		dropdown3.ClearOptions();
//		arr3.Add ("Select Student");
//		for(int i = 0; i<jsonvale3["arr"].Count; i++)
//		{
//
//
//			arr3.Add(jsonvale3["arr"][i]["student_first_name"].ToString() +" "+ jsonvale3["arr"][i]["student_last_name"].ToString()+"-");
//		}    
//
//		dropdown3.AddOptions (arr3);
//	}




	IEnumerator getKids()
	{

		//Debug.Log ("IMG ER");



	    //string schoolId = jsonvale ["arr"][selection]["id"].ToString ();
		//	var www = new WWWForm();
		var headers = new Dictionary<string,string>();
		headers.Add("Content-Type", "application/json");
		headers.Add("Authorization", "Token fb547117f0fb75a6a57692e45d148d6e86524a6c");
		//Debug.Log (schoolId);
		string url = "https://leb-container-test.azurewebsites.net/api/clm-rs/?school=365";//+schoolId;
		WWW www = new WWW(url, null, headers);
		yield return www;
		if (www != null)
		{
			Processjson2(www.text);
			//Debug.Log(www.text);

		}
		else
		{
			Debug.Log ("" +
				"No DATA");
		}        
	}



}
