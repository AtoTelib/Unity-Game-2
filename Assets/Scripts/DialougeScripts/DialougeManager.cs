using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;
    public Animator animator;
   
    public static bool grannyInteract=false;
private  Queue<string> sentences;
    void Start()
    {
        sentences=new Queue<string>();  
    }
    public void StartDialouge(Dialouge dialouge){

        animator.SetBool("isOpen",true);
        grannyInteract=true;
     //   

        nameText.text=dialouge.name;

        sentences.Clear();

        foreach(string sentence in dialouge.sentences){
            sentences.Enqueue(sentence);
            
        }
        DisplayNextSentence();

    }

    public void DisplayNextSentence(){
        if(sentences.Count==0){
            EndDialouge();
            return;
        }
        string sentence=sentences.Dequeue();
       // dialougeText.text=sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));


    }

    IEnumerator TypeSentence(string sentence){
        dialougeText.text="";
        foreach(char letter in sentence.ToCharArray()){
            dialougeText.text += letter;
            yield return null;
            yield return null;
            yield return null;
        }
    }
    public void EndDialouge(){
        animator.SetBool("isOpen",false);
    //    grannyAnimator.SetBool("interact",false);
        grannyInteract=false;


    }

  
}
