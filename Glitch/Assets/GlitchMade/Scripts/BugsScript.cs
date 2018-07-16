using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// this is for crafting all of the specific bugs
public class BugsScript : MonoBehaviour {
    public GameObject player;
    public Vector3 playerPos;

    //forgive me father for getting the prefab this way
    public GameObject errorMessage;


    public bool isFall;
    public bool startButtonClicked;
	// Use this for initialization
	void Start () {
        isFall = false;
        startButtonClicked = false;
	}
	
	// Update is called once per frame
    //the majority of the bugs will be checked for here
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
            missingFloor.errorMessage.text = "Floor not scripted, please return for updates";
            
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
