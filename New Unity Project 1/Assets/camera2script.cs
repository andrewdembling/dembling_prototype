using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			//transform.position= new Vector3(GameObject.Find("destroyer").GetComponent<Transform>().position.x, GameObject.Find("destroyer").GetComponent<Transform>().position.y,-200);
		transform.position= new Vector3(GameObject.Find("Abra").GetComponent<Transform>().position.x, GameObject.Find("Abra").GetComponent<Transform>().position.y,-50);
		
		//if (Input.GetKey(KeyCode.X))
		//{
		//	transform.position = new Vector3(GameObject.Find("Player").GetComponent<Transform>().position.x, GameObject.Find("Player").GetComponent<Transform>().position.y, -20);
		//}
		//if (Input.GetKey(KeyCode.C))
		//{
		//	transform.position= new Vector3(GameObject.Find("apple").GetComponent<Transform>().position.x, GameObject.Find("apple").GetComponent<Transform>().position.y,-20);
		//}
			//transform.position= new Vector3(
			//	((GameObject.Find("Poop_Emoji").GetComponent<Transform>().position.x)+(GameObject.Find("Player").GetComponent<Transform>().position.x)+(GameObject.Find("apple").GetComponent<Transform>().position.x))/3,
			//	((GameObject.Find("Poop_Emoji").GetComponent<Transform>().position.y)+(GameObject.Find("Player").GetComponent<Transform>().position.y)+(GameObject.Find("apple").GetComponent<Transform>().position.y)/3),-50);
	}
}
