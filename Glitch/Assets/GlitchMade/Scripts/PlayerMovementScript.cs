using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;


	
public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody rb;
    protected Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        if (Input.GetButtonDown("Horizontal"))
        {
            transform.Translate(0, 0, Input.GetAxis("Horizontal") + 0.1f);
            Debug.Log("yee");
        }
        else
        {
        }
    }

}