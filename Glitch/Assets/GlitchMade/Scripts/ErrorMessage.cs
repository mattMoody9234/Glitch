using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorMessage : MonoBehaviour {
    public GameObject debugCanvas;
    public Text errorMessage;

    public BugsScript gameManager;
    Rigidbody playerRigid;
    // Use this for initialization
    void Start () {
        playerRigid = gameManager.player.GetComponent<Rigidbody>();
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
        playerRigid.velocity = new Vector3(0, 0, 0);
    }
}
