using UnityEngine;
using System.Collections;

public class rainbow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("changeColor",0.1f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void changeColor(){
		Color newColor = getRandomColor ();
		GetComponent<Renderer> ().material.SetColor ("_EmissionColor", newColor);
		GetComponent<Light> ().color = newColor;
	}

	Color getRandomColor(){
		float red = Random.value;
		float green = Random.value;
		float blue = Random.value;
		return new Color (red, green, blue);
	}
}
