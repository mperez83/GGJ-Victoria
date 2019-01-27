using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUpdated : MonoBehaviour
{
    public GameObject[] ingredients;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn1()
    {
        yield return new WaitForSeconds(Random.Range(0.25f, 0.50f));
        Instantiate(ingredients[Random.Range(0,ingredients.Length)], new Vector3(Random.Range(-10.0f, 10.0f), 15, 0), Quaternion.identity);
        StartCoroutine(Spawn2());
    }

    IEnumerator Spawn2()
    {
        yield return new WaitForSeconds(Random.Range(0.25f, .50f));
        Instantiate(ingredients[Random.Range(0, ingredients.Length)], new Vector3(Random.Range(-10.0f, 10.0f), 15, 0), Quaternion.identity);
        StartCoroutine(Spawn1());
    }
}
