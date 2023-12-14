using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnloadOnStart : MonoBehaviour
{
    public GameObject UnloadedPanel;
    // Start is called before the first frame update
    void Start()
    {
        UnloadedPanel.SetActive(false);
    }
}
