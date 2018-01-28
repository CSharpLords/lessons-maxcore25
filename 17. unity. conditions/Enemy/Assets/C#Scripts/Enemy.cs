using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{
	public Transform enemy;
	// Use this for initialization
	void Start () 
	{
		print (enemy.position.x);

	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance(enemy.position, transform.position);
		print (dist);
	}
}
