using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BgScroll : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSizeZ;
	private Vector2 startPosition;
	
	// Use this for initialization
	void Start ()
	{
		startPosition = transform.position;

	}
	
	// Update is called once per frame
	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPosition + ((Vector2.down *newPosition) + (Vector2.right * newPosition)/2);

	}
}
