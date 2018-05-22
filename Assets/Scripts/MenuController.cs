using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {


    public static string player_name = "";
    public InputField nameText;


    public void playGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    // Use this for initialization
    void Start () {

        GameObject inputField = GameObject.Find("InputField");
        nameText = inputField.GetComponent<InputField>();
    }
	
	// Update is called once per frame
	void Update () {
        player_name = nameText.text;
    }
}
