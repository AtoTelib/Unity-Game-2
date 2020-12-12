using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyAnimations : MonoBehaviour
{
     public Animator grannyAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DialougeManager.grannyInteract){
            grannyAnimator.SetBool("interact",true);
        }else {
            grannyAnimator.SetBool("interact",false);
        }
        
    }
   
}
