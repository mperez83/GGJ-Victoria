using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerSwordShield : MonoBehaviour
{
    public TMP_Text m_time;
    private float time = 60f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        m_time.text = "Time: " + time.ToString("F2");
        if (time <= 0f)
        {
            SceneManager.LoadScene("LoseScreenSwordShield");
        }
    }
}
