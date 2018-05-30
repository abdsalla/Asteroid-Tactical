using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameMananger.instance.enemies.Add(this); // add enemy to list on start of game
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy () //function for what happens when an enemy is destroyed
	{
		GameMananger.instance.enemies.Remove(this);
	}
}
