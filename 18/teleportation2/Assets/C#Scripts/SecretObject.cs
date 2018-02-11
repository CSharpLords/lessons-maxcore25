using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretObject : MonoBehaviour 
{
	public Transform secretObject;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance (secretObject.position, transform.position);
		if (dist < 2) 
		{

			print ("Победа! Секретный объект найден!");
		}
	}
}
