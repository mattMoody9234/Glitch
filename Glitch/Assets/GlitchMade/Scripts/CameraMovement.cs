using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class CameraMovement : MonoBehaviour {
    public GameObject player;
    float x;
    float y;
    float z;
    float yaw;
    float pitch;

    bool rotate;
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

        yaw = 0.0f;
        pitch = 0.0f;

        rotate = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotate = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            rotate = false;
        }
        if (rotate == true/* && transform.rotation.y >= 90.0f && transform.rotation.y <= 180.0f*/)
        {
            yaw += Input.GetAxis("Mouse X");
            pitch -= Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        transform.LookAt(newPos);
        //transform.Translate(Vector3.right * Time.deltaTime);
    }
    void LateUpdate()
    {
        x = player.transform.position.x;
        y = player.transform.position.y + 3.0f;
        z = player.transform.position.z - 2.0f;
        //reset position behind character

        newPos.x = x;
        newPos.y = y;
        newPos.z = z;
        transform.position = newPos;

    
    }
}
