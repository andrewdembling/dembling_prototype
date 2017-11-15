using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public Rigidbody2D MyRigidbody2D;
	public float ForceStrength;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetAxis("Horizontal") > 0)
	{
		MyRigidbody2D.AddForce(Vector2.right * ForceStrength);
		MyRigidbody2D.AddForce(Vector2.up * ForceStrength/2);
	}
		
	}
}
