using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject angryTextUI;
    // public GameObject MoreIngredientsUI;
    public GameObject youWinUI;
    public bool set = false;
    public bool onePanelLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
    //     if (onePanelLoaded == false){
    //     Debug.Log("GGGGGGG");
    //   } keeps going true.. 
    }

    public void gameOver()
    {
        // if (!onePanelLoaded)
        if (youWinUI.activeSelf)
        {
            angryTextUI.SetActive(false);
            gameOverUI.SetActive(true);
            onePanelLoaded = true;
     
        }
        else {
            onePanelLoaded = true;
             gameOverUI.SetActive(true);
             angryTextUI.SetActive(false);
         
        }

    }

    public void angry()
    {
        if (!onePanelLoaded)
        {
            angryTextUI.SetActive(true);
            // onePanelLoaded = false;
        }
    }

    public void win()
    {
        if (!onePanelLoaded)
        {
            gameOverUI.SetActive(false);
            angryTextUI.SetActive(false);
            youWinUI.SetActive(true);
            onePanelLoaded = true;
           
        }
    }

    
    public void restart()
    {
        onePanelLoaded = false;
        SceneManager.LoadScene("PirateTavern");
    }

    // When loading new scenes, drag and drop the scene from Assets into the Project Manager Scene Loader
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Won't work in editor, you have to build it
    public void quit()
    {
        Application.Quit();
    }

    public void nextScene()
    {
        SceneManager.LoadScene("second scene");
    }
}
