using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroHandler : MonoBehaviour
{
    public Image fadeOverlay;
    public Sprite still2;
    public SpriteRenderer sr;

    void Start()
    {
        LeanTween.value(1, 0, 2).setOnUpdate((float value) =>
        {
            fadeOverlay.color = new Color(fadeOverlay.color.r, fadeOverlay.color.g, fadeOverlay.color.b, value);
        }).setOnComplete(() =>
        {
            StartCoroutine(IntroSequence());
        });
    }

    IEnumerator IntroSequence()
    {
        yield return new WaitForSeconds(2);
        sr.sprite = still2;
        yield return new WaitForSeconds(2);

        yield return null;
    }
}
