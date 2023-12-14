using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    
public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     ResetMenu.SetActive(false);
    // }

    // Update is called once per frame
    public void Restart()
    {
        // condition needed
        // ResetMenu.SetActive(true);
        SceneManager.LoadScene("PirateTavern");
    }
}
