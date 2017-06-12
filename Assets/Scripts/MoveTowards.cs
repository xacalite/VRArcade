﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {

    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
    public void SetTarget (Transform toSet)
    {
        target = toSet;
    }

	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
