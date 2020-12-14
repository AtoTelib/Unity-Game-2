using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TefiniConv : MonoBehaviour
{
    bool happy;
    Animator anim;
    public static int character;
    public Animator buttonAnimator;

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
    }
    private void OnTriggerExit(Collider other)
    {
        buttonAnimator.SetBool("interactButton", false);
    }
}
