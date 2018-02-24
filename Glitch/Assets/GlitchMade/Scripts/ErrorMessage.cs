using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorMessage : MonoBehaviour {
    public GameObject debugCanvas;
    public GameObject player;
    public Vector3 playerPos;
    
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
        player.transform.position = playerPos;
    }
}
