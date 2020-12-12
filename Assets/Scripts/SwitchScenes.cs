using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SwitchScenes : MonoBehaviour
{

    public float delay = 3.0f;
    public string NewLevel= "MainMenu";
    // Start is called before the first frame update
    void Start()
    {
        //so that only the scene switch is delayed not the entire app
         StartCoroutine(LoadLevelAfterDelay(delay));
        
    }

    // Update is called once per frame
         IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
         SceneManager.LoadScene(NewLevel);
     }
}