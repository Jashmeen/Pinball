using UnityEngine;
using System.Collections;

public class flipperController : MonoBehaviour {

	public GameObject ball;
	public float flipperForce;

	void Start ()
	{
		GetComponent<Rigidbody> ().maxAngularVelocity = 60;
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.RightShift) && this.tag.Contains("right")) {
			GetComponent<Rigidbody> ().AddTorque (0, Time.deltaTime * 10000000, 0);
		}
		else if(Input.GetKeyDown(KeyCode.LeftShift)&& this.tag.Contains("left")){
			GetComponent<Rigidbody> ().AddTorque (0, Time.deltaTime * -10000000, 0);
		}
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel("PinballScene");
		}
	}

}
