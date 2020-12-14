using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class searchingForPurpose : MonoBehaviour
{
    public Transform[] target;
    public Transform ball;
    private Animator anim;
    private float timer =1;
    private bool walking;
        private bool reading;

    private NavMeshAgent agent;
    private int i=0;
    private bool l ;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent=GetComponent<NavMeshAgent>();
        GoToNext();
        Increment();
    }
void GoToNext(){
        agent.destination = target[i].position;
}
void Increment(){
        i=(i+1)%target.Length;
}
    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance<=0 && i==2 && reading&& !walking){
            transform.rotation=new Quaternion(0,-90.0f,0,0);
            anim.SetBool("sit",true);
            timer =Random.Range(20, 56);
            walking=true;
        }
        if(timer<=0 && walking){
            walking=false;
            anim.SetBool("walking",false);
            // Increment();
            reading=false;
        }
        if(timer<=4 && walking){
            anim.SetBool("walking",true);
            anim.SetBool("sit",false);
        }
//        Debug.Log(i);
         if(agent.remainingDistance<=2  && !walking && l&& !reading){
            GoToNext();
            Increment();
           l=false;
        }else if (agent.remainingDistance<=2 && i==2){
            reading=true;
            l=true;
        }else{
            l=true;

        }

        
        if(timer>0 && walking)
            timer-=Time.deltaTime;        
        if(Input.GetButton("Jump"))
        agent.destination = ball.position;
    }
}