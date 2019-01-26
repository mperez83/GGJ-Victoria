using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroHandler : MonoBehaviour
{
    public Image fadeOverlay;
    public Sprite still2;
    public Sprite runningBackground;
    public SpriteRenderer sr;
    public GameObject runningGirlPrefab;

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
        yield return new WaitForSeconds(1);
        //Play crashing audio
        yield return new WaitForSeconds(2);
        sr.sprite = still2;
        yield return new WaitForSeconds(2);
        sr.sprite = runningBackground;
        sr.gameObject.transform.Translate(new Vector2(-5, 0));
        LeanTween.moveX(sr.gameObject, sr.gameObject.transform.position.x + 10, 7);
        GameObject runningGirl = Instantiate(runningGirlPrefab);
        LeanTween.moveX(runningGirl, -11.5f, 5);
        yield return new WaitForSeconds(6);
        LeanTween.value(0, 1, 2).setOnUpdate((float value) =>
        {
            fadeOverlay.color = new Color(fadeOverlay.color.r, fadeOverlay.color.g, fadeOverlay.color.b, value);
        }).setOnComplete(() =>
        {
            SceneManager.LoadScene("WitchScene");
        });
    }
}
