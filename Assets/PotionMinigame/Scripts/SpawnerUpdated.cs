using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUpdated : MonoBehaviour
{
    public GameObject[] ingredients;
    private float min = 0.1f;
    private float max = 0.50f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn1());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 20)
        {
            max = 0.4f;
        }
        else if (timer > 50)
        {
            max = 0.3f;
            min = 0.05f;
        }
    }

    IEnumerator Spawn1()
    {
        yield return new WaitForSeconds(Random.Range(min, max));
        Instantiate(ingredients[Random.Range(0,ingredients.Length)], new Vector3(Random.Range(-10.0f, 10.0f), 15, 0), Quaternion.identity);
        StartCoroutine(Spawn2());
    }

    IEnumerator Spawn2()
    {
        yield return new WaitForSeconds(Random.Range(min, max));
        Instantiate(ingredients[Random.Range(0, ingredients.Length)], new Vector3(Random.Range(-10.0f, 10.0f), 15, 0), Quaternion.identity);
        StartCoroutine(Spawn1());
    }
}
