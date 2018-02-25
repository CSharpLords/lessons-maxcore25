using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusAge : MonoBehaviour 
{
	
	public Text ageField;
	// Use this for initialization
	void Start () 
	{
		
		Button plus = GetComponent<Button> ();
		plus.onClick.AddListener (Increase);
		ageField.text = "18";
	}
	
	// Update is called once per frame
	void Increase () 
	{
		MinusAge.age = MinusAge.age + 1;
		ageField.text = MinusAge.age.ToString ();

	}
}
