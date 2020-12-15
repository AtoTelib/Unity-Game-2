using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialougeManager : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;
    public Animator animator;

    public static bool grannyInteract = false;

    public GameObject Player;
    private static Queue<string> sentences;

    

    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialouge(Dialouge dialouge)
    {
  //      Debug.Log("Step B");
        animator.SetBool("isOpen", true);
        grannyInteract = true;
        //   

        nameText.text = dialouge.name;

        sentences.Clear();

        foreach (string sentence in dialouge.sentences)
        {
            Debug.Log(sentence);
            sentences.Enqueue(sentence);

        }
        Debug.Log("Sentences Before " + sentences.Count);
        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        Debug.Log("Step C");

        if (sentences.Count == 0)
        {


            //        Debug.Log("ICCC");
            EndDialouge();
            return;
        }
        Debug.Log("Sentences What? ");
        string sentence = sentences.Dequeue();


        if (sentences.Count ==1)
        {
    //        Debug.Log("INNNN");
            SceneManager.LoadScene("Quiz", LoadSceneMode.Additive);

        }
        //      dialougeText.text=sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log("Sentences After HERE " + sentences.Count);


    }

    IEnumerator TypeSentence(string sentence)
    {
        dialougeText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialougeText.text += letter;
            yield return null;

        }
    }
    public void EndDialouge()
    {
        animator.SetBool("isOpen", false);
        //    grannyAnimator.SetBool("interact",false);
        grannyInteract = false;


    }


}
