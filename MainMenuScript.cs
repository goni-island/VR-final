using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // When loading new scenes, drag and drop the scene from Assets into the Project Manager Scene Loader
    public void PlayGame()
    {
        SceneManager.LoadScene("PirateTavern");
    }

    // Won't work in editor, you have to build it
    public void quit()
    {
        Application.Quit();
    }
}
