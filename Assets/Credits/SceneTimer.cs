using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimer : MonoBehaviour
{
    public int maxTime = 20;
    float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        EndCredits();
    }

    void EndCredits()
    {
        if(t > maxTime)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
