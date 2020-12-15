using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkConv : MonoBehaviour
{
    bool happy;
    Animator anim;
    public static int character;
    public Animator buttonAnimator;
    public GameObject referenceConv;

    public GameObject conv;
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
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnTriggerEnter(Collider other)
    {

        buttonAnimator.SetBool("interactButton", true);
        referenceConv.GetComponent<GrannyAnimations>().setCharacter(1);
        conv.GetComponent<DialougeTrigger>().setCharacter(1);
    }
    private void OnTriggerExit(Collider other)
    {
        buttonAnimator.SetBool("interactButton", false);
    }
}
