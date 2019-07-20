using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrownCalc : MonoBehaviour
{
    public static int totalScore = 0;
    float timeLeft = 30;
    Text scoreTxt;
    public static float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        scoreTxt.text = "Medal taken: " + totalScore + "\n Time left: " + (int)Mathf.Round(timeLeft) + "s.";
        if (timeLeft < 0)
        {
            ScoreCalculate.totalScore = 0;
            CrownCalc.totalScore = 0;
            SceneManager.LoadScene("GameOver");
        }

        if (totalScore >= 5)
        {
            SceneManager.LoadScene("Complete");
        }
    }

    public void resetScore()
    {
        totalScore = 0;
    }
}