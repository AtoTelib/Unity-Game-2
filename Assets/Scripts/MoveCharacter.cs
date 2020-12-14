using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class MoveCharacter : MonoBehaviour
{
    bool enter = false;
    Animator anim;
    Transform position;

    public Transform[] goal;
    public bool shouldTurn;

    //private NavMeshAgent agent;
    //public Transform target; //i only need pos of target
    //array of targets 
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //agent = GetComponent<NavMeshAgent>();
        index =0;  //which target am i at
        //agent.SetDestination(goal[index].position);


        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.WalkingZ"))
 {
//     Debug.Log("walking");
     // AudioManager.footsteps=true;

     if(index<2){
    // Avoid any reload.
 
        if(Math.Abs(this.transform.position.x - goal[index].position.x)<=0.05){

             shouldTurn = true;
             
             index=index+1;
            //  if(index>1){
            //      index=0;

            //  }

         }

         else{
             enter = false;
         }
        //  if(shouldTurn && !enter){
        //      anim.SetTrigger("ShouldTurn");
        //      transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
        //      enter = true;
        //      shouldTurn = false;
        //      }

         
         if(index==0){
             //shouldTurn = false;
             //enter = false;
             transform.Translate(7*Vector3.forward * Time.deltaTime);
             //anim.SetBool("ShouldTurn", false);
            
         }
         else{
             //shouldTurn = false;
             //enter = false;
             transform.Translate(7*Vector3.forward * Time.deltaTime*-1);
             //anim.SetBool("ShouldTurn", false);
           //   AudioManager.footsteps=true;


         }
         

 }
 anim.SetTrigger("ShouldTurn");
 }
         

         
        
        
    }
}
