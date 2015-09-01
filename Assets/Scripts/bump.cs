using UnityEngine;
using System.Collections;

public class bump : MonoBehaviour {

	public GameObject ball;
	public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		foreach(ContactPoint contact in col.contacts){
			ball.GetComponent<Rigidbody>().AddForce(-1*contact.normal*force, ForceMode.Impulse);
		}
	}
}
