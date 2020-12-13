using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 1;
    public float rotation = 1;
    private bool moveup;
    private bool movedown;
    private Vector3 moved;

    bool animation_started = false;
    bool animation_finished = false;
    Animator anim;
    private Rigidbody controller;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = gameObject.GetComponent<Rigidbody>();
        moved = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 move = new Vector3(0, 0, 1);

        // float x = Input.GetAxis("Vertical")* speed *Time.deltaTime;
        // transform.Translate(0,0,x);
        float y = Input.GetAxis("Horizontal") * rotation * Time.deltaTime;
        transform.Rotate(0, y, 0);
    //    Debug.Log(Input.GetAxis("Vertical"));
        if (Input.GetAxis("Vertical") > 0)
        {
   //         Debug.Log(Input.GetAxis("Vertical"));
            anim.Play("James_Walking");
            Vector3 moving = transform.forward * Input.GetAxis("Vertical") * speed;
            controller.AddForce(moving);
            // moved+=moving;
            // controller.velocity=transform.forward *speed*Input.GetAxis("Vertical");

        }
        if (Input.GetAxis("Vertical") == 0)
        {
            anim.Play("James_Idle1");
    
            // controller.velocity=new Vector3(controller.velocity.x,controller.velocity.y, 0);
            // controller.AddForce(-transform.forward* speed);
            controller.ResetCenterOfMass();
            // moved =new Vector3(0, 0, 0);

        }
    }

 
}