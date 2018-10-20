using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))	
		{

			transform.Translate (0, 0, -Time.deltaTime * speed);
		}

		else if(Input.GetKey(KeyCode.S)) 
		{
			
			transform.Translate (0, 0, Time.deltaTime * speed);
		}
	}
}