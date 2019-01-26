using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class WitchSceneHandler : MonoBehaviour
{
    public Image fadeOverlay;
    public GameObject witchPrefab;
    public Flowchart flowchart;

    void Start()
    {
        LeanTween.value(1, 0, 2).setOnUpdate((float value) =>
        {
            fadeOverlay.color = new Color(fadeOverlay.color.r, fadeOverlay.color.g, fadeOverlay.color.b, value);
        }).setOnComplete(() =>
        {
            StartCoroutine(WitchSequence());
        });
    }

    void Update()
    {
        
    }

    IEnumerator WitchSequence()
    {
        yield return new WaitForSeconds(1);
        GameObject witch = Instantiate(witchPrefab);
        LeanTween.moveX(witch, 3.75f, 3).setEase(LeanTweenType.easeOutQuad);
        yield return new WaitForSeconds(3.5f);
        flowchart.ExecuteBlock("Witch Start Speak");
    }
}
