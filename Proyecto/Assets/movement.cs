﻿using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		velocity += gravity;

		transform.position += gravity * Time.deltaTime;
	}
}
