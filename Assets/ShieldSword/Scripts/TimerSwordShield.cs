using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerSwordShield : MonoBehaviour
{
    public TMP_Text m_time;
    public GameObject player_man;
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
        if (time <= 0f && player_man.GetComponent<PlayerShieldSword>().pts < 100)
        {
            SceneManager.LoadScene("LoseScreenSwordShield");
        }
        else if (time <= 0f && player_man.GetComponent<PlayerShieldSword>().pts >= 100)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
