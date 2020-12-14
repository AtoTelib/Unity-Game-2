using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  
    public AudioSource GameRunning;
    public AudioSource fountainAudio;

    public AudioSource ButtonPOP;

    public AudioSource Footsteps;

    public static AudioManager AudioManagerInstance;

    public static bool inFountain=false;
    public static bool popButton=false;

    public static bool footsteps=false;


  



    void Awake()
    {
        GameRunning.Play();
        GameRunning.loop=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(inFountain==true){
            FountainSound();
        }

        if(popButton==true)
        PopButton();

        if(footsteps==true){
            footstepAudio();
        }
     
    }
    void FountainSound(){
       
        fountainAudio.Play();
    //    inFountain=false;
 
    }
    void PopButton(){
        ButtonPOP.Play();
        popButton=false;
    }
    void footstepAudio(){
        Footsteps.Play();
   //     Debug.Log("step");
     //   footsteps=false;
    }
    
}
