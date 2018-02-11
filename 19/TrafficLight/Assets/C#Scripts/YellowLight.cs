﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowLight : MonoBehaviour 
{
	Renderer render;
	float time = 0;
	// Use this for initialization
	void Start () 
	{
		render = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		time = time + Time.deltaTime;
		if(time > 3)
		{
			time = 0;
		}
		if (time > 2) 
		{
			render.material.color = Color.white;
		} 
		else if (time > 1) 
		{
			render.material.color = Color.yellow;
		}
	}
}
