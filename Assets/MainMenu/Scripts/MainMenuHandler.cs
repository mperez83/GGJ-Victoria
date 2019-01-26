using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public Image fadeOutOverlay;

    public void StartGame()
    {
        LeanTween.value(0, 1, 2).setOnUpdate((float value) =>
        {
            fadeOutOverlay.color = new Color(fadeOutOverlay.color.r, fadeOutOverlay.color.g, fadeOutOverlay.color.b, value);
        }).setOnComplete(() =>
        {
            SceneManager.LoadScene("IntroScene");
        });
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}