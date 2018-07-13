using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class CameraMovement : MonoBehaviour {
    public GameObject player;
    float x;
    float y;
    float z;


  

    Vector3 newPos;
    // Use this for initialization
    void Start () {
        x = player.transform.position.x;
        y = player.transform.position.y;
        z = player.transform.position.z;
        transform.Translate(x, y, z);

        x = player.transform.position.x;
        y = player.transform.position.y + 3.0f;
        z = player.transform.position.z - 2.0f;


    }
    //try to use the unit circle

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    rotate = true;
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    rotate = false;
        //}
    
    }
    void LateUpdate()
    {
        newPos.x = player.transform.position.x;
        newPos.y = player.transform.position.y + 3.0f;
        newPos.z = player.transform.position.z - 2.0f;

        //reset position behind character



      //  transform.rotation = player.transform.rotation;    
      //  transform.position = newPos;

    //    transform.LookAt(newPos);


    }
}
