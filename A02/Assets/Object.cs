using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject[] gemObjects;

    // Start is called before the first frame update
    void Start()
    {
        int randomM = 5;
        int randomN = 5;
        for (int i = 0; i < randomM; i++)
            for (int j = 0; j < randomN; j++)
            {
                int rndDiamond = Random.Range(0, gemObjects.Length);
                Instantiate(gemObjects[rndDiamond], new Vector2(i * 1.5f,j * 1.5f), Quaternion.identity);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
