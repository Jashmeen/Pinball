using UnityEngine;
using System.Collections;

public class ballPush : MonoBehaviour {

	bool collided;
	public GameObject ball;
	float power;

	// Use this for initialization
	void Start () {
		power = 0;
		collided = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(collided && Input.GetKey(KeyCode.Space)){
			power += 0.5f;
			if(power > 30){
				power = 30f;
			}
		}
		if(collided && Input.GetKeyUp(KeyCode.Space)){
			ball.GetComponent<Rigidbody> ().AddForce(0,0,-10*power);
			ball.GetComponent<TrailRenderer>().enabled = true;
			power = 0;
		}

	}

	void OnTriggerEnter(Collider other){
		collided = true;
	}

	void OnTriggerExit(Collider other){
		collided = false;
	}
}
