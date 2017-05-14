﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	public float speed= 1f;


	private void Start()
	{
		speed = Random.Range(20f, 24f);
	}
	private void FixedUpdate()
	{
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.deltaTime);
	}
}
