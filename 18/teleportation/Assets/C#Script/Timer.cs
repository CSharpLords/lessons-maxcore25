using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour 
{
	public Transform enemy;
	float time = 0;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds = (int)time;
		//print(seconds);
		if (seconds == 15) 
		{
			transform.position = new Vector3 (0, 0, 0); 
		}
		float dist = Vector3.Distance(enemy.position, transform.position);
		if (dist <= 3) 
		{

			print ("Победа! Секретный предмет найден!");
		}
	}
}
