using UnityEngine;
using System.Collections;

public class boostSpeed : MonoBehaviour {

	public float velocityBoost;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		Vector3 vel = col.gameObject.GetComponent<Rigidbody>().velocity;
		vel*=velocityBoost;
		col.gameObject.GetComponent<Rigidbody>().velocity = vel;
	}

}
