using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
	public float speed;
	private float xdirection=0;
	private float zdirection=0;
	// Use this for initialization
	void Start () {
		xdirection = Random.Range (-1f, 1f);
		zdirection = Random.Range (-1f,1f);
		while (xdirection == .4f) {
			xdirection = Random.Range (-1f,1f);

		}
		while (zdirection == .4f) {
			zdirection = Random.Range (-1f, 1f);
		}

		Vector3 movement = new Vector3 (xdirection,0,zdirection);
		this.GetComponent<Rigidbody> ().AddForce (movement * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
