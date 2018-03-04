using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BugsScript : MonoBehaviour {
    public GameObject player;
    public Vector3 playerPos;

    public GameObject errorMessage;


    public bool isFall;
	// Use this for initialization
	void Start () {
        isFall = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFall == false && player.transform.position.y < -20.0f)
        {
            isFall = true;
            


            ErrorMessage fallError = instantiatePopUp();
            fallError.errorMessage.text = "You fell my man";
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "MissingPannel")
        {
            ErrorMessage missingFloor = instantiatePopUp();
            missingFloor.errorMessage.text = "floor not scripted, please return for updates";
            
        }
    }

    ErrorMessage instantiatePopUp()
    {
        GameObject curError = Instantiate(errorMessage);

        ErrorMessage error = curError.GetComponentInChildren<ErrorMessage>();
        error.gameManager = this;

        return error;
    }



}
