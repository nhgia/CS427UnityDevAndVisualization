using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goBackToMenu()
    {
        SceneManager.LoadScene("A01");
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void goToCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void goToPreA01()
    {
        SceneManager.LoadScene("PreA01");
    }

    public void goToPreA02()
    {
        SceneManager.LoadScene("PreA02");
    }
    public void goToA02()
    {
        SceneManager.LoadScene("A02");
    }
}
