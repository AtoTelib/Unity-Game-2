using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffects : MonoBehaviour
{
    //Fade time in seconds
         public float fadeOutTime;
         public Text text;
         public float alpha;
    // Start is called before the first frame update
    void Start()
    {

        text = GetComponent<Text>();
        alpha =0.0f;

        
    }

    // Update is called once per frame
    void Update()
    {

        
        if(alpha<1.0f){
            Color originalColor = text.color;

             for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
             {
                 //text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t/fadeOutTime));
                 //Color originalColor  = text.color;
                 originalColor.a = alpha+0.00001f;
                 alpha = alpha+0.00001f;
                 text.color = originalColor;
                 
             }
        }
        
    }

    
}

