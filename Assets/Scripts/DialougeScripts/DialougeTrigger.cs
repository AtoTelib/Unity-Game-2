using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
 public Dialouge dialouge1;
 public Dialouge dialouge2;
 public Dialouge dialouge3;
 public Dialouge dialouge4;
 public Dialouge dialouge5;
 public Dialouge dialouge6;

    public static int character;

    public int getCharacter()
    {
        return character;
    }

    public void setCharacter(int a)
    {
        character = a;
    }
    public void TriggerDialouge(){
     if(character == 0)
        {
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge1);
        }
        if(character == 1)
        {
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge2);
        }
        if(character == 2)
        {
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge3);
        }
        if(character == 3)
        {
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge4);
        }
        if(character == 4)
        {
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge5);
        }
        if(character == 5)
        {
            FindObjectOfType<DialougeManager>().StartDialouge(dialouge6);
        }
        
 }
}
