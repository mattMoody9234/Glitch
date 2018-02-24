using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class CameraMovement : MonoBehaviour {
    public GameObject player;
    float x;
    float y;
    float z;
    // Use this for initialization
    void Start () {
        x = player.transform.position.x;
        y = player.transform.position.y + .1f;
        z = player.transform.position.z + .1f;
        transform.Translate(x, y, z);

    }

    void LateUpdate()
    {
        x = player.transform.position.x;
        y = player.transform.position.y + 4.0f;
        z = player.transform.position.z - 3.0f;
        Vector3 newPos;
        newPos.x = x;
        newPos.y = y;
        newPos.z = z;
        transform.position = newPos;
    }
}
