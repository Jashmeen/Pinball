using UnityEngine;
using System.Collections;

public class killYourself : MonoBehaviour {
	

	void Awake(){
		Destroy(gameObject, 1);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
