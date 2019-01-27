using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button m_startButton;

    public void StartGame()
    {
        Time.timeScale = 1;
        Destroy(GameObject.Find("Canvas2"));
    }
}
