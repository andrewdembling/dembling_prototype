using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float timer;

	// Use this for initialization
	void Start ()
	{
		Spawn();

	}

	void Spawn()
	{			
		var floor = Instantiate(obj[Random.Range(0, 1)], transform.position*(Random.Range(-4,4)), transform.rotation);
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
		Destroy(floor, 4);
		//	timer += 1.0F * Time.deltaTime;
	//	if (timer >= 3)
	//	{
	//		GameObject.Destroy(floor);
	//	}
	}
	}
	
	// Update is called once per frame
//	void Update () {
		
//}
