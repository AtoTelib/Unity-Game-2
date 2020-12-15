using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyAnimations : MonoBehaviour
{
     public Animator grannyAnimator;
     public Animator buttonAnimator;

    public GameObject conv;

    public static int character;
    
    public int getCharacter()
    {
        return character;
    }

    public void setCharacter(int a)
    {
        character = a;
    }
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
        AudioManager.popButton=true;
        setCharacter(0);
        conv.GetComponent<DialougeTrigger>().setCharacter(0);
    }
    private void OnTriggerExit(Collider other) {
        buttonAnimator.SetBool("interactButton",false);
        AudioManager.popButton=false;

    }
   
}
