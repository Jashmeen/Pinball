using UnityEngine;
using System.Collections;

public class lightUpWhenHit : MonoBehaviour {

	Light thislight;
	Material thisMat;

	// Use this for initialization
	void Start () {
		thislight = GetComponent<Light>();
		thisMat = GetComponent<Renderer>().material;
		Color startColor = getRandomColor();
		thislight.color = startColor;
		thisMat.color = startColor;

	}
	
	// Update is called once per frame
	void Update () {
		if(thislight.intensity > 0)
			thislight.intensity=thislight.intensity-.05f;
	}

	void OnCollisionEnter(Collision col){
		Color changeTo = getRandomColor();
		thislight.intensity = 8;
		thislight.color = changeTo;
		thisMat.color = changeTo;

	}

	Color getRandomColor(){
		float red = Random.value;
		float green = Random.value;
		float blue = Random.value;
		return new Color (red, green, blue);
	}
}
