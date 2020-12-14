using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountainSound : MonoBehaviour
{
     private void OnTriggerEnter(Collider other) {
        AudioManager.inFountain=false;
       // Debug.Log("In fountain");
      //  Debug.Log(AudioManager.inFountain);

    }

    private void OnTriggerExit(Collider other) {
        AudioManager.inFountain=true;
      //  Debug.Log("Out of fountain");
       // Debug.Log(AudioManager.inFountain);


    }
}
