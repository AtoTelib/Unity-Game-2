using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public Button startButton ;
    public Button creditsButton;
    public Button moreInfoButton;
    public Button quitButton;
    string gameScene = "GardenScene";
    string creditsScene ="CreditsScene";
    string moreInfoScene = "MoreInfoScene";
    // Start is called before the first frame update
    void Start()
    {//yourButton.GetComponent<Button>();

        Button startButtonComponent = startButton.GetComponent<Button>();
        Button creditsButtonComponent = creditsButton.GetComponent<Button>();
        Button moreInfoButtonComponent = moreInfoButton.GetComponent<Button>();
        Button quitButtonComponent = quitButton.GetComponent<Button>();
        Debug.Log(startButtonComponent);

		startButtonComponent.onClick.AddListener(StartGame);
        creditsButtonComponent.onClick.AddListener(ShowCredits);
        moreInfoButtonComponent.onClick.AddListener(ShowMoreInfo);
        quitButtonComponent.onClick.AddListener(Quit);
    }

    public void StartGame(){
        //Debug.Log("CLICKED");
        SceneManager.LoadScene(gameScene);
		
	}
    public void ShowCredits(){
        //Debug.Log("CLICKED");
        SceneManager.LoadScene(creditsScene);
		
	}
    
    public void ShowMoreInfo(){
        //Debug.Log("CLICKED");
        SceneManager.LoadScene(moreInfoScene);
		
	}
    
    public void Quit(){
        Application.Quit();
		
	}
    

    // Update is called once per frame
    void Update()
    {

        
    }
}
