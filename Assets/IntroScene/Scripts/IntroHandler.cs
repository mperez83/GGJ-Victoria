using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroHandler : MonoBehaviour
{
    public Image fadeOverlay;
    public Sprite doorOpen;
    public SpriteRenderer sr;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        LeanTween.value(1, 0, 1).setOnUpdate((float value) =>
        {
            fadeOverlay.color = new Color(fadeOverlay.color.r, fadeOverlay.color.g, fadeOverlay.color.b, value);
        }).setOnComplete(() =>
        {
            StartCoroutine(IntroSequence());
        });
    }

    IEnumerator IntroSequence()
    {
        audioSource.Play();
        yield return new WaitForSeconds(5.5f);
        sr.sprite = doorOpen;
        yield return new WaitForSeconds(4.5f);
        LeanTween.value(0, 1, 1).setOnUpdate((float value) =>
        {
            fadeOverlay.color = new Color(fadeOverlay.color.r, fadeOverlay.color.g, fadeOverlay.color.b, value);
        }).setOnComplete(() =>
        {
            SceneManager.LoadScene("WitchScene");
        });
    }
}
