﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(30, 45, 60) * Time.deltaTime);
	}
}
