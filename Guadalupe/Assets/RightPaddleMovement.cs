using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleMovement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))	
		{
			
			transform.Translate (0, 0, -Time.deltaTime *speed);
		}

		else if(Input.GetKey(KeyCode.DownArrow)) 
		{

			transform.Translate (0, 0, Time.deltaTime * speed);
		}

	}
}
