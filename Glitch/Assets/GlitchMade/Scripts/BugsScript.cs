using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsScript : MonoBehaviour {
    public GameObject player;

    private bool isFall;
	// Use this for initialization
	void Start () {
        isFall = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y < -20.0f)
        {
            isFall = true;
        }
	}

    void LateUpdate()
    {
        if(isFall == true)
        {
           // in
        }
    }
}
