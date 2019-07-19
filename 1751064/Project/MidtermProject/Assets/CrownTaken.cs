using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrownTaken : MonoBehaviour
{
    public GameObject medal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //audioOnTrapTriggered.Play();
        CrownCalc.totalScore += 1;
        medal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
