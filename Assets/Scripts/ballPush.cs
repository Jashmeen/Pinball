using UnityEngine;
using System.Collections;

public class ballPush : MonoBehaviour {

	bool collided;
	public GameObject ball;
	public float multiplier;
	float power;

	// Use this for initialization
	void Start () {
		power = 0;
		collided = false;
	}
	
	// Update is called once per frame
	void Update () {
//		if (collided && Input.GetKeyDown (KeyCode.Space)) {
//			ball.GetComponent<Rigidbody> ().AddForce(0,0,-1500);
//		}
		if(collided && Input.GetKey(KeyCode.Space)){
			Debug.Log ("+power");
			power += 0.2f;
			if(power > 80){
				power = 80f;
			}
		}
		if(collided && Input.GetKeyUp(KeyCode.Space)){
			ball.GetComponent<Rigidbody> ().AddForce(0,0,-1*multiplier*power);
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
