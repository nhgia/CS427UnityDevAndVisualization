using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrapTriggered : MonoBehaviour
{
    public GameObject character;
    public AudioSource audioOnTrapTriggered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //audioOnTrapTriggered.Play();
        ScoreCalculate.totalScore = 0;
        CrownCalc.totalScore = 0;
        SceneManager.LoadScene("GameOver");
        character.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
