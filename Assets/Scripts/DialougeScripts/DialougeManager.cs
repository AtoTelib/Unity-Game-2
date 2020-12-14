using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;
    public Text dialougeAnswer1;
    public Text dialougeAnswer2;
    public Animator animator;
   
    public static bool grannyInteract=false;
private  static Queue<string> sentences;
private static Queue<string> answers;
    void Start()
    {
        sentences=new Queue<string>();  
        answers =new Queue<string>(); 
    }
    public void StartDialouge(Dialouge dialouge){

        animator.SetBool("isOpen",true);
        grannyInteract=true;
       
        nameText.text=dialouge.name;

        sentences.Clear();

        foreach(string sentence in dialouge.sentences){
            sentences.Enqueue(sentence);
            
            
        }
        answers.Clear();
       foreach(string answer in dialouge.answers){
            answers.Enqueue(answer);
                
        }
       
    //    Debug.Log(answers.Count);

        DisplayNextSentence();
       // DisplayAnswers();

    }

    public void DisplayNextSentence(){
        if(sentences.Count==0){
            EndDialouge();
            return;
        }
        Debug.Log(sentences.Count);
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

         
        }
         DisplayAnswers();
     
       
    }

     void DisplayAnswers(){
        
        Debug.Log(answers.Count);
        if(answers.Count==0){
             return;
       }

       
        string answer1=answers.Dequeue();
        string answer2=answers.Dequeue();
        dialougeAnswer1.text=answer1;
        dialougeAnswer2.text=answer2;
         
    }
    public void EndDialouge(){
        animator.SetBool("isOpen",false);
    //    grannyAnimator.SetBool("interact",false);
        grannyInteract=false;


    }

  
}
