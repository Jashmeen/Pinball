using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {

	public GameObject ball;
	public GameObject ballSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("entered dead zone");
		ball.transform.position = ballSpawn.transform.position;
	}
}
