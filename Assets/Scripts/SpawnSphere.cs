using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject sphere;

    // Use this for initialization
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void spawnSphere()
    {
        Instantiate(sphere, new Vector3(-6.49f, 0.02f, -0.04296875f), Quaternion.identity);
    }
}
