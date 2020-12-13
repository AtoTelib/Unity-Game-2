using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyAnimations : MonoBehaviour
{
     public Animator grannyAnimator;
     public Animator buttonAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DialougeManager.grannyInteract){
            grannyAnimator.SetBool("interact",true);
            buttonAnimator.SetBool("interactButton",false);
        }else {
            grannyAnimator.SetBool("interact",false);
        //    buttonAnimator.SetBool("interactButton",true);
        }

      
        
    }
    private void OnTriggerEnter(Collider other) {
        buttonAnimator.SetBool("interactButton",true);
    }
    private void OnTriggerExit(Collider other) {
        buttonAnimator.SetBool("interactButton",false);
    }
   
}
