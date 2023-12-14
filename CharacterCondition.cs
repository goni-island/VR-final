using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCondition : MonoBehaviour
{

    public GameObject angry;
    public GameObject win;


    Animator animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (win.activeSelf)
        {
            animation.SetTrigger("Happy");

        }

        if (angry.activeSelf)
        {
            Debug.Log("test");
            animation.SetTrigger("Sad");
        }
        
    }
}
