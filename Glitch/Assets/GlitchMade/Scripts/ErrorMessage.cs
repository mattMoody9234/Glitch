using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorMessage : MonoBehaviour {
    public GameObject debugCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        Destroy(debugCanvas);
    }
}
