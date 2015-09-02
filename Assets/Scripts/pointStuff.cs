using UnityEngine;
using System.Collections;

public class pointStuff : MonoBehaviour {

	public GameObject otherPointThing1;
	public GameObject otherPointThing2;
	public float speed;
	public bool isHit;
	public bool isMoving;
	Vector3 defaultPos;
	Vector3 downPos;
	Vector3 goingTowards;

	void Start () {
		isHit = false;
		isMoving = false;
		defaultPos = transform.position;
		downPos = new Vector3(transform.position.x, transform.position.y-0.74f, transform.position.z); 
	}
	
	void Update () {
		if(isMoving){
			transform.position = Vector3.MoveTowards (transform.position, goingTowards, speed);
		}
		if (transform.position.Equals(goingTowards)){
			isMoving = false;
		}
	}

	void OnCollisionEnter(Collision col){
		isHit = true;
		goToDownPosition();
		if(otherPointThing1.GetComponent<pointStuff>().isHit && otherPointThing2.GetComponent<pointStuff>().isHit){
			Debug.Log("add 500");
			StartCoroutine(popUp(5));
		}
		else{
			Debug.Log("add 100");
		}
	}

	IEnumerator popUp(float waitTime){
		yield return new WaitForSeconds (waitTime);
		otherPointThing1.GetComponent<pointStuff>().goToUpPosition();
		otherPointThing2.GetComponent<pointStuff>().goToUpPosition();
		goToUpPosition();
	}

	public void goToUpPosition(){
		goingTowards = defaultPos;
		isMoving = true;
	}

	public void goToDownPosition(){
		goingTowards = downPos;
		isMoving = true;
	}
}
