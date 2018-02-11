﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mines : MonoBehaviour 
{
	public Transform player;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance (player.position, transform.position);
		if (dist < 2) 
		{

			player.position = new Vector3 (0, 0, 0);
		}
	}
}
