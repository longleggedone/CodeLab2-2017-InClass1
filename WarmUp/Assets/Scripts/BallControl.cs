using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	private Rigidbody2D rb2d;
	private Vector2 velocity;

	public float speed = 20f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		Invoke("Move", 1);
	}
		
	// Update is called once per frame
	void Move () {
		rb2d.AddForce(transform.up * speed);
	}

	void OnCollisionEnter2D (Collision2D col) {
		
	}
}
