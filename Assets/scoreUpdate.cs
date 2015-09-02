using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class scoreUpdate : MonoBehaviour {

	public static int overallScore;
	public static int livesRemaining;

	public GameObject text;
	public GameObject lives;
	Text score;
	Text balls;

	// Use this for initialization
	void Start () {
		overallScore = 0;
		livesRemaining = 5;
		score = text.GetComponent<Text>();
		balls = lives.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + overallScore;
		balls.text = "Balls: " + livesRemaining;
	}
}
