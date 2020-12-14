using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public int c;
    public Animator buttonAnimator;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Jump");
        GameObject.Find("YogaCharacter").GetComponent<GrannyAnimations>().setCharacter(1);
    
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("stand") == false)
        {
      
  //          anim.Play("Jump");
 //           anim.SetBool("stand", false);
        }
        else{
   
    //        anim.Play("Stand");
 //           anim.SetBool("stand", true);
           

        }

 //       anim.SetBool("stand", !anim.GetBool("stand"));
       
    }


    private void OnTriggerEnter(Collider other)
    {
        buttonAnimator.SetBool("interactButton", true);
        GameObject.Find("YogaCharacter").GetComponent<GrannyAnimations>().setCharacter(1);
    }
    private void OnTriggerExit(Collider other)
    {
        buttonAnimator.SetBool("interactButton", false);
    }

    public void StandingEnded()
    {
        anim.Play("Jump");
        /*     if (anim.GetCurrentAnimatorStateInfo(0).IsName("Stand"))
             {
                 anim.Play("Jump");
                 //Bunch of code, Replace myAnimator with a reference to your Animator component
             }
             else{
                 anim.Play("Stand");
             }*/
        //      anim.SetBool("stand", !anim.GetBool("stand"));
    }

    public void JumpingEnded()
    {
        anim.Play("Stand");
        /*     if (anim.GetCurrentAnimatorStateInfo(0).IsName("Stand"))
             {
                 anim.Play("Jump");
                 //Bunch of code, Replace myAnimator with a reference to your Animator component
             }
             else{
                 anim.Play("Stand");
             }*/
        //      anim.SetBool("stand", !anim.GetBool("stand"));
    }
}
