using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public Button startButton ;
    public Button optionsButton;
    public Button quitButton;
    string gameScene = "GardenScene";
    string optionsScene ="OptionsScene";
    // Start is called before the first frame update
    void Start()
    {//yourButton.GetComponent<Button>();

        Button startButtonComponent = startButton.GetComponent<Button>();
        Button optionsButtonComponent = optionsButton.GetComponent<Button>();
        Button quitButtonComponent = quitButton.GetComponent<Button>();
        Debug.Log(startButtonComponent);

		startButtonComponent.onClick.AddListener(StartGame);
        optionsButtonComponent.onClick.AddListener(Options);
        quitButtonComponent.onClick.AddListener(Quit);

        
    }

    public void StartGame(){
        Debug.Log("CLICKED");
        SceneManager.LoadScene(gameScene);
		
	}
    public void Options(){
        SceneManager.LoadScene(optionsScene);
	}
    public void Quit(){
        Application.Quit();
		
	}
    

    // Update is called once per frame
    void Update()
    {

        
    }
}
