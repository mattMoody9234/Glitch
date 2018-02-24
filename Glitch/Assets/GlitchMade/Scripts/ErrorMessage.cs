using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorMessage : MonoBehaviour {
    public GameObject debugCanvas;
    public Text errorMessage;

    public BugsScript gameManager;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        resetCharacter();
        Destroy(debugCanvas);
    }

    void resetCharacter()
    {
        gameManager.player.transform.position = gameManager.playerPos;
        gameManager.isFall = false;
    }
}
