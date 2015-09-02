using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {

	public GameObject ball;
	public GameObject ballSpawn;
	public GameObject gameOverText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		scoreUpdate.livesRemaining-=1;
		ball.GetComponent<TrailRenderer>().enabled = false;
		if(scoreUpdate.livesRemaining >= 0){
			ball.transform.position = ballSpawn.transform.position;
		}
		else{
			gameOverText.SetActive(true);
		}
	}
}
