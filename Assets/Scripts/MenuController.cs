using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {


    public static string player_name = "";
    public InputField nameText;


    public void playLvl1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void playLvl2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void playLvl3()
    {
        SceneManager.LoadScene("Level 3");
    }

    // Use this for initialization
    void Start () {

        GameObject inputField = GameObject.Find("InputField");
        nameText = inputField.GetComponent<InputField>();

        Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update () {
        player_name = nameText.text;
    }
}
