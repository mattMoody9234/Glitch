using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;


	
public class GlitchPlayerControl : MonoBehaviour
{
    Rigidbody rb;
    protected Animator animator;

    bool isHMoving;
    bool isVMoving;
    bool isJumping;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        isHMoving = false;
        isVMoving = false;
        isJumping = false;
    }


    void Update()
    {
        //get buttons down
        if (Input.GetButtonDown("Horizontal"))
        {
            isHMoving = true; 
            animator.SetBool("Move", true);
        }
        if (Input.GetButtonDown("Vertical"))
        {
            isVMoving = true;
            animator.SetBool("Move", true);
        }
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            animator.SetTrigger("Jump");
           // rb.AddForce(transform.up +* 1300 .0f);
            transform.Translate(0, Input.GetAxis("Vertical")  + 2.0f,0.0f);
        }

        //get buttons up
        if (Input.GetButtonUp("Horizontal"))
        {
            isHMoving = false;
        }
        if (Input.GetButtonUp("Vertical"))
        {
            isVMoving = false;
        }

        if (isHMoving == false && isVMoving == false)
        {
            animator.SetBool("Move", false);
        }

        // check input variables

        //move left or right
        if (isHMoving == true)
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f,0,0);
        }
        //move forward or backward
        if (isVMoving == true)
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 10.0f);
        }


    }

}