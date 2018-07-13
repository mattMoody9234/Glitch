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

    float prevMousePosY;

    bool rotate;

    bool rotatingCharacter;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        isHMoving = false;
        isVMoving = false;
        isJumping = false;

        rotate = false;
        rotatingCharacter = false;

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
            transform.Translate(0, Input.GetAxis("Vertical") + 2.0f, 0.0f);
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
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f, 0, 0);
        }
        //move forward or backward
        if (isVMoving == true)
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 10.0f);
        }
        //rotation 
        if (Input.GetMouseButtonDown(0))
        {
            rotate = true;
            prevMousePosY = Input.mousePosition.y;
            Debug.Log("Down");
        }
        if (Input.GetMouseButtonUp(0))
        {
            rotate = false;
        }

        //trying to figure out a solid rotating thing
        if (rotate)
        {

            // float xRot =  Input.mousePosition.x - prevMousePosX;
            if ((Input.mousePosition.x < prevMousePosY + 1.0f) && (Input.mousePosition.x > prevMousePosY - 1.0f))
            {

            }
            else
            {
                Vector3 rotateMe;

                if ((prevMousePosY - Input.mousePosition.x) > 0)
                {
                    rotateMe = new Vector3(0.0f, -1.0f, 0.0f);

                }
                else
                {
                    rotateMe = new Vector3(0.0f, 1.0f, 0.0f);

                }

                transform.Rotate(rotateMe * Time.deltaTime * 100.0f);

                Debug.Log("rotateing");
            }

            

            prevMousePosY = Input.mousePosition.x;
        }
    }
    void LateUpdate()
    {


    }
}