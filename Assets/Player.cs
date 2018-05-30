using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Transform transform;
	public float movespeed;
	public float turnspeed;

	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform>();
		GameMananger.instance.player = this; // everything can find the player through the GameManager
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + (Vector3 * movespeed);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate = transform.Rotate + (Vector3 * turnspeed);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate = transform.Rotate + (Vector3 * turnspeed);
		}
	}
}
