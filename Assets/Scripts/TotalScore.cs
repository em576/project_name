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

        if (Level1Controller.levelComplete == true)
        {
            score = Level1Controller.totalScore;
        }
        if (Level2Controller.levelComplete == true)
        {
            score = Level2Controller.totalScore;
        }
    }
	
	// Update is called once per frame
	void Update () {
        totalScore.text = "You got a total of " + score + " out of 10!";
	}

    public void playAgain()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
