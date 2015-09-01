using UnityEngine;
using System.Collections;

public class flipperController : MonoBehaviour {

	void Start ()
	{
		GetComponent<Rigidbody> ().maxAngularVelocity = 25; // make sluggish at first
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.RightShift) && this.tag.Contains("right")) {
			GetComponent<Rigidbody> ().AddTorque (0, Time.deltaTime * 10000000, 0);
		}
		else if(Input.GetKeyDown(KeyCode.LeftShift)&& this.tag.Contains("left")){
			GetComponent<Rigidbody> ().AddTorque (0, Time.deltaTime * -10000000, 0);
		}
	}
}
