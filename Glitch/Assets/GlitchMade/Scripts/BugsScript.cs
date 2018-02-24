using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsScript : MonoBehaviour {
    public GameObject player;
    public Vector3 playerPos;

    public GameObject errorMessage;

    GameObject curError;
    private bool isFall;
	// Use this for initialization
	void Start () {
        isFall = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFall == false && player.transform.position.y < -20.0f)
        {
            isFall = true;
            
            curError = Instantiate(errorMessage);
            ErrorMessage error = curError.GetComponent<ErrorMessage>();
            
            error.player = player;


        }
    }

    void LateUpdate()
    {
        
    }


    
}
