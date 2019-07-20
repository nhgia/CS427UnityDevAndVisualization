using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculate : MonoBehaviour
{

    public static int totalScore = 0;
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
        scoreTxt.text = "Total score: " + totalScore;

    }

    public void resetScore()
    {
        totalScore = 0;
    }
}