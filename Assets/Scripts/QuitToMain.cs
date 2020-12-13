using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitToMain : MonoBehaviour
{
    string mainMenuScene = "MainMenu";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            
           quitToMainMenu();
        }
        
    }
    public void quitToMainMenu(){

         SceneManager.LoadScene(mainMenuScene);

    }
}
