using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenuButtons : MonoBehaviour
{
    public CanvasGroup pauseMenu; //this is the whole menu, this variable is used for hiding / showing
    public Button unpauseButton;
    
    public Button quitToMainButton;
    string mainMenuScene = "MainMenu";
    // Start is called before the first frame update
    bool paused;

    
    void Start()
    {
        Time.timeScale =1;
        paused = false;
        pauseMenu = pauseMenu.GetComponent<CanvasGroup>();

        Button unpauseButtonComponent = unpauseButton.GetComponent<Button>();
        Button quitToMainButtonComponent = quitToMainButton.GetComponent<Button>();

        unpauseButtonComponent.onClick.AddListener(UnpauseGame);
        quitToMainButtonComponent.onClick.AddListener(quitToMainMenu);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            
            paused = !paused;
            if(paused){
                PauseGame();
            }
            else{
                UnpauseGame();
            }
        }

        
    }

    public void PauseGame(){
        Time.timeScale =0;
        pauseMenu.alpha =1;

    }

    public void UnpauseGame(){
        Time.timeScale =1;
        pauseMenu.alpha =0;

    }
    public void quitToMainMenu(){

        if(paused){

        Time.timeScale =1;
        StartCoroutine(LoadYourAsyncScene());
         //SceneManager.LoadScene(mainMenuScene);
        }

    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(mainMenuScene);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
