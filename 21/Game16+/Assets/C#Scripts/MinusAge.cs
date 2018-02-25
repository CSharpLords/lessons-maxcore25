using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusAge : MonoBehaviour 
{

	public Text ageField;
	public static int age = 18;

	void Start () 
	{
		
		Button plus = GetComponent<Button> ();
		plus.onClick.AddListener (Decrease);
		ageField.text = "18";


	}
	
	// Update is called once per frame
	void  Decrease () 
	{
		age = age - 1;
		ageField.text = age.ToString ();
	}
}