using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject blue;
    public GameObject smile;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn1());
    }

    IEnumerator Spawn1()
    {
        yield return new WaitForSeconds(2);
        Instantiate(blue, new Vector3(5, 0, 0), Quaternion.identity);
        StartCoroutine(Spawn2());
    }

    IEnumerator Spawn2()
    {
        yield return new WaitForSeconds(2);
        Instantiate(smile, new Vector3(-5, 0, 0), Quaternion.identity);
        StartCoroutine(Spawn1());
    }

}
