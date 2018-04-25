using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameController : MonoBehaviour {

    public GameObject sphere;

    public Text score;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        GameObject[] sphereCount = GameObject.FindGameObjectsWithTag("sphere") as GameObject[];
        score.text = "" + sphereCount.Length;
    }

    public void spawnSphere()
    {
        Instantiate(sphere, new Vector3(-6.49f, 0.02f, -0.04296875f), Quaternion.identity);
    }

    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }
}
