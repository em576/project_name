using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameController : MonoBehaviour {

    public GameObject oxygen;
    public GameObject hydrogen;
    public GameObject carbon;
    public GameObject phospherus;
    public GameObject sodium;
    public GameObject potassium;
    public GameObject calcium;
    public GameObject copper;
    public GameObject sulfur;
    public GameObject nitrogen;
    public GameObject iron;
    public GameObject chloride;

    public int currentLevel;
    public int nextLevel;

    int currentNoOxygen;
    int currentNoHydrogen;
    int currentNoCarbon;
    int currentNoPhospherus;
    int currentNoSodium;
    int currentNoPotassium;
    int currentNoCalcium;
    int currentNoCopper;
    int currentNoSulfur;
    int currentNoNitrogen;
    int currentNoIron;
    int currentNoChloride;
    public int answerOxygen;
    public int answerHydrogen;
    public int answerCarbon;
    public int answerPhospherus;
    public int answerSodium;
    public int answerPotassium;
    public int answerCalcium;
    public int answerCopper;
    public int answerSulfur;
    public int answerNitrogen;
    public int answerIron;
    public int answerChloride;

    public static int totalScore;
    public int nextQuestionNo = 1;
    public GameObject nextLevelButton;
    public GameObject spawnButton;
    public GameObject resetButton;
    public GameObject outofTime;
    public GameObject correct;
    public GameObject wrong;
    public GameObject tryAgain;
    public GameObject gameOver;
    public GameObject menuButton;
    public Text lives;
    public Text question;
    public GameObject time;
    public Text timeText;
	public float timeLimit = 0;
	private float timeTaken = 0;
    private float startTime = 0;
    public int livesLeft;
    public string player_name = "";
    public string nextQuestion;
    public Text playerName;


    // Use this for initialization
    void Start() {
        outofTime.SetActive(false);
        nextLevelButton.SetActive(false);
        correct.SetActive(false);
        wrong.SetActive(false);

        player_name = MenuController.player_name;
        playerName.text = "Name: " + player_name;

        nextQuestion = "Test1";
        question.text = "Question: " + nextQuestion;
    }

    void Update() {
		timeTaken = Mathf.Round(timeLimit -(startTime + Time.time)); 

        GameObject[] oxygenCount = GameObject.FindGameObjectsWithTag("oxygen") as GameObject[];
        currentNoOxygen = oxygenCount.Length;
        GameObject[] hydrogenCount = GameObject.FindGameObjectsWithTag("hydrogen") as GameObject[];
        currentNoHydrogen = hydrogenCount.Length;
        GameObject[] carbonCount = GameObject.FindGameObjectsWithTag("carbon") as GameObject[];
        currentNoCarbon = carbonCount.Length;
        GameObject[] phospherusCount = GameObject.FindGameObjectsWithTag("phospherus") as GameObject[];
        currentNoPhospherus = phospherusCount.Length;
        GameObject[] sodiumCount = GameObject.FindGameObjectsWithTag("sodium") as GameObject[];
        currentNoSodium = sodiumCount.Length;
        GameObject[] potassiumCount = GameObject.FindGameObjectsWithTag("potassium") as GameObject[];
        currentNoPotassium = potassiumCount.Length;
        GameObject[] calciumCount = GameObject.FindGameObjectsWithTag("calcium") as GameObject[];
        currentNoCalcium = calciumCount.Length;
        GameObject[] copperCount = GameObject.FindGameObjectsWithTag("copper") as GameObject[];
        currentNoCopper = copperCount.Length;
        GameObject[] sulfurCount = GameObject.FindGameObjectsWithTag("sulfur") as GameObject[];
        currentNoSulfur = sulfurCount.Length;
        GameObject[] nitrogenCount = GameObject.FindGameObjectsWithTag("nitrogen") as GameObject[];
        currentNoNitrogen = nitrogenCount.Length;
        GameObject[] ironCount = GameObject.FindGameObjectsWithTag("iron") as GameObject[];
        currentNoIron = ironCount.Length;
        GameObject[] chlorideCount = GameObject.FindGameObjectsWithTag("chloride") as GameObject[];
        currentNoChloride = chlorideCount.Length;

        timeText.text = "Time: " + timeTaken;

        if(timeTaken == 0)
        {
            outofTime.SetActive(true);
            time.SetActive(false);
        }

        lives.text = "Lives: " + livesLeft;
        
    }

    public void spawnOxygen()
    {
        Instantiate(oxygen, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnHydrogen()
    {
        Instantiate(hydrogen, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnCarbon()
    {
        Instantiate(carbon, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnPhospherus()
    {
        Instantiate(phospherus, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnSodium()
    {
        Instantiate(sodium, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnPotassium()
    {
        Instantiate(potassium, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnCalcium()
    {
        Instantiate(calcium, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnCopper()
    {
        Instantiate(copper, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnSulfur()
    {
        Instantiate(sulfur, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnNitrogen()
    {
        Instantiate(nitrogen, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnIron()
    {
        Instantiate(iron, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }
    public void spawnChloride()
    {
        Instantiate(chloride, new Vector3(-2.08f, 0.02f, -0.04296875f), Quaternion.identity);
    }

    public void playGame()
    {
        totalScore = 0;
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1;
    }

    public void mainMenu()
    {
        totalScore = 0;
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void newQuestion()
    {
        if(nextQuestionNo == 2)
        {
            questionTwo();
        }
    }
    
    public void resetLvl()
    {
        GameObject[] oxygens;

        oxygens = GameObject.FindGameObjectsWithTag("oxygen");

        foreach (GameObject oxygen in oxygens)
        {
            Destroy(oxygen);
        }
        GameObject[] hydrogens;

        hydrogens = GameObject.FindGameObjectsWithTag("hydrogen");

        foreach (GameObject hydrogen in hydrogens)
        {
            Destroy(hydrogen);
        }
        GameObject[] carbons;

        carbons = GameObject.FindGameObjectsWithTag("carbon");

        foreach (GameObject carbon in carbons)
        {
            Destroy(carbon);
        }
        GameObject[] phospheruss;

        phospheruss = GameObject.FindGameObjectsWithTag("phospherus");

        foreach (GameObject phospherus in phospheruss)
        {
            Destroy(phospherus);
        }
        GameObject[] sodiums;

        sodiums = GameObject.FindGameObjectsWithTag("sodium");

        foreach (GameObject sodium in sodiums)
        {
            Destroy(sodium);
        }
        GameObject[] potassiums;

        potassiums = GameObject.FindGameObjectsWithTag("potassium");

        foreach (GameObject potassium in potassiums)
        {
            Destroy(potassium);
        }
        GameObject[] calciums;

        calciums = GameObject.FindGameObjectsWithTag("calcium");

        foreach (GameObject calcium in calciums)
        {
            Destroy(calcium);
        }
        GameObject[] coppers;

        coppers = GameObject.FindGameObjectsWithTag("copper");

        foreach (GameObject copper in coppers)
        {
            Destroy(copper);
        }
        GameObject[] sulfurs;

        sulfurs = GameObject.FindGameObjectsWithTag("sulfur");

        foreach (GameObject sulfur in sulfurs)
        {
            Destroy(sulfur);
        }
        GameObject[] nitrogens;

        nitrogens = GameObject.FindGameObjectsWithTag("nitrogen");

        foreach (GameObject nitrogen in nitrogens)
        {
            Destroy(nitrogen);
        }
        GameObject[] irons;

        irons = GameObject.FindGameObjectsWithTag("iron");

        foreach (GameObject iron in irons)
        {
            Destroy(iron);
        }
        GameObject[] chlorides;

        chlorides = GameObject.FindGameObjectsWithTag("chloride");

        foreach (GameObject chloride in chlorides)
        {
            Destroy(chloride);
        }
        Time.timeScale = 1;
    }

    public void checkAnswer()
    {
        if(currentNoOxygen == answerOxygen && currentNoHydrogen == answerHydrogen && currentNoCarbon == answerCarbon && currentNoPhospherus == answerPhospherus && currentNoSodium == answerSodium &&
            currentNoPotassium == answerPotassium && currentNoCalcium == answerCalcium && currentNoCopper == answerCopper && currentNoSulfur == answerSulfur && currentNoNitrogen == answerNitrogen &&
            currentNoIron == answerIron && currentNoChloride == answerChloride)
        {
            //Display correct
            correct.SetActive(true);
            nextLevelButton.SetActive(true);
            resetButton.SetActive(false);
            totalScore++;
            nextQuestionNo++;

        }
        else
        {
            wrong.SetActive(true);
            //Display wrong
            if (livesLeft == 0) {
                gameOver.SetActive(true);
                wrong.SetActive(false);
                spawnButton.SetActive(false);
                resetButton.SetActive(false);
                menuButton.SetActive(true);
                Time.timeScale = 0;
            }
            if(livesLeft > 0) {
                livesLeft = livesLeft - 1;
            }
            tryAgain.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void tryAgainButton()
    {
        Time.timeScale = 1;
        tryAgain.SetActive(false);
        wrong.SetActive(false);
    }
    public void questionTwo()
    {
        correct.SetActive(false);
        nextLevelButton.SetActive(false);
        spawnButton.SetActive(true);
        resetButton.SetActive(true);
        nextQuestion = "Test2";
        question.text = "Question: " + nextQuestion;

        answerOxygen = 1;
        answerHydrogen = 0;
        answerCarbon = 0;
        answerPhospherus = 0;
        answerSodium = 0;
        answerPotassium = 0;
        answerCalcium = 0;
        answerCopper = 0;
        answerSulfur = 0;
        answerNitrogen = 0;
        answerIron = 0;
        answerChloride = 0;
    }
}
