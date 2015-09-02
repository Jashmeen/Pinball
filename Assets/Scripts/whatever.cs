using UnityEngine;
using System.Collections;

public class whatever : MonoBehaviour {

	void Awake(){
		GetComponent<Rigidbody>().maxAngularVelocity = Mathf.Infinity;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag.Equals("bumper")){
			Instantiate(Resources.Load("sound"));
			scoreUpdate.overallScore+=10;
		}
	}
}
