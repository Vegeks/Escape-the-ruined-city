using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelociy;
    private bool isGrounded;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }

    public void ProcessMove(Vector3 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelociy.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelociy.y < 0)
        {
            playerVelociy.y = -2f;
        }
        controller.Move(playerVelociy * Time.deltaTime);
        Debug.Log(playerVelociy.y);

    }
    public void Jump()
    {
        if (isGrounded)
        {
            playerVelociy.y = Mathf.Sqrt(jumpHeight * -1.5f * gravity);
        }
    }
}
