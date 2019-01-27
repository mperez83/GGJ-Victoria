using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreenHandler : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene("PotionMinigame");
    }
}