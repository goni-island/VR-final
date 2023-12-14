using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] float startingTime;

    // For GameManager to call Restart Screen
    public GameManagerScript gameManager;
    private bool isDead;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }

        if (remainingTime <= (startingTime / 2) && (remainingTime > 0))
        {
            gameManager.angry();
        }

        else if (remainingTime < 0)
        {
            remainingTime = 0;
            if (!isDead)
            {
                isDead = true;
                gameManager.gameOver();
            }
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
