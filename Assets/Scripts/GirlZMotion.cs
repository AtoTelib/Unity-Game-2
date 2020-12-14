using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GirlZMotion : MonoBehaviour
{
    
    Animator anim;

    public Transform[] goal;
    public bool idle;


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

     if(index<2){
    // Avoid any reload.
 
        if(Math.Abs(this.transform.position.x - goal[index].position.x)<=0.05){

        
             
             index=index+1;
            //  if(index>1){
            //      index=0;
            //  }

         }

        

         
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

         }
         

 }
 else{
     idle = true;
     anim.SetBool("idle",true);

 }
 }
         

         
        
        
    }
}
