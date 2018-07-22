using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	int score;
	public Text score_text;
	public bool alive;

	void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		score = 0;
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (alive)
		{
			score += 10;
			score_text.text = score.ToString("000000");
		}
	}
}
