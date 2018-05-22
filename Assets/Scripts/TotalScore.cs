using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalScore : MonoBehaviour {

    public Text totalScore;
    public static int score;

	// Use this for initialization
	void Start () {

        score = GameController.totalScore;
	}
	
	// Update is called once per frame
	void Update () {
        totalScore.text = "You got a total of " + score + " out of 5!";
	}

    public void playAgain()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
