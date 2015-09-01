using UnityEngine;
using System.Collections;

public class flipperController : MonoBehaviour {

	public GameObject ball;
	public float flipperForce;
	Collision currentCol;
	bool colliding;

	void Start ()
	{
		colliding = false;
		GetComponent<Rigidbody> ().maxAngularVelocity = 60;
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.RightShift) && this.tag.Contains("right")) {
			GetComponent<Rigidbody> ().AddTorque (0, Time.deltaTime * 10000000, 0);
			if(colliding){
				foreach(ContactPoint contact in currentCol.contacts){
					ball.GetComponent<Rigidbody>().AddForce(-1*contact.normal*flipperForce, ForceMode.Impulse);
				}
			}
		}
		else if(Input.GetKeyDown(KeyCode.LeftShift)&& this.tag.Contains("left")){
			GetComponent<Rigidbody> ().AddTorque (0, Time.deltaTime * -10000000, 0);
			if(colliding){
				foreach(ContactPoint contact in currentCol.contacts){
					ball.GetComponent<Rigidbody>().AddForce(-1*contact.normal*flipperForce, ForceMode.Impulse);
				}
			}
		}
	}

	void OnCollisionEnter (Collision col){
		colliding = true;
		currentCol = col;
	}

	void OnCollisionExit(Collision col){
		colliding = false;
		currentCol = null;
	}
}
