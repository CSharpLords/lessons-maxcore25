using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maxhight : MonoBehaviour 
{
	float maxHight = 0;
	float minHight = 0;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y > maxHight) 
		{
			maxHight = transform.position.y;
			print ("Максимальная высота: " + maxHight);
		}
		if (transform.position.y < minHight) 
		{
			minHight = transform.position.y;
			print ("Минимальная высота: " + minHight);
		}
	}
}
