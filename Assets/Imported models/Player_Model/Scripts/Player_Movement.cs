using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{  CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Animator anim;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
                    anim = GetComponent<Animator>();

    }

    void Update()
    {
        
        if (characterController.isGrounded)
        {
        float y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Rotate(0, y, 0);
        if (Input.GetAxis("Vertical") != 0)
        {
            moveDirection = transform.forward* Input.GetAxis("Vertical");
            moveDirection *= speed;
            anim.Play("James_Walking");
        }
        if (Input.GetAxis("Vertical") == 0)
        {
            anim.Play("James_Idle1");

        }
            // We are grounded, so recalculate
            // move direction directly from axes

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}