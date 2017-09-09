﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    private Vector3 posA;
    private Vector3 posB;

    private Vector3 NextPos;

    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;

	// Use this for initialization
	void Start () {

        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        NextPos = posB;
    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}


    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, NextPos, speed * Time.deltaTime);


        if(Vector3.Distance(childTransform.localPosition,NextPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        NextPos = NextPos != posA ? posA : posB;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.layer = 10;
            other.transform.SetParent(childTransform);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        other.transform.SetParent(null);
    }
}
