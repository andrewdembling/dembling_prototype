using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deesttroyer : MonoBehaviour
{
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Platform")
		{
			Debug.Break();
		}
		else
		{
			Destroy(other.gameObject);
		}
	}
}
