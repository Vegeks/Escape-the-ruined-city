using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.8f;
    public float jumpHeight = 1.5f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;


    public GameObject playerObj;


    void Start()
    {
        //If you want to find it by NAME. For this you have to make sure you only have 1 object named "Player".
       /* if (playerObj == null)
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        //Debug.Log(isGrounded);
       // Debug.Log("IsGrounded1 = " + isGrounded);

        
        //if (isGrounded && velocity.y < -20)
      //  {
          //  velocity.y = -2f; 
    //
       // }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetButtonDown("Jump") && isGrounded && velocity.y<-5)
        {

            velocity.y = Mathf.Sqrt(jumpHeight * -1.5f * gravity);
         //   Debug.Log("Jump!");
            
        }

        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * speed* Time.deltaTime);
        // controller.Move(move * speed * Time.deltaTime);

        // velocity.y += gravity * Time.deltaTime;
        //Debug.Log(velocity.y);
        // controller.Move(velocity * speed * Time.deltaTime);

        //if(isGrounded==false)
        //{
        //    isGrounded = true;
        //}

        /* void OnCollisionEnter(Collision col)
         {
             if (col.gameObject.name == "FallCheck")
             {
                 Debug.Log("Collision Detected!");
                 SceneManager.LoadScene("EndScreen");
             }

         } */

        //Debug.Log("Player Position: X = " + playerObj.transform.position.x + " --- Y = " + playerObj.transform.position.y + " --- Z = " + playerObj.transform.position.z);
        /*  
           if (playerObj.transform.position.y == -95.58752)
           {
               Debug.Log("Collision Detected!");
               SceneManager.LoadScene("EndScreen");
           }
       }
        */
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FallCheck")
        {
            //Debug.Log("Collision Detected!");
            SceneManager.LoadScene("EndScreen");
        }

    }    

}
