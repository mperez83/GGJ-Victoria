using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditShieldSword : MonoBehaviour
{
    Vector2 pos;
    int x;
    public GameObject bandit;
    int count; 

    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (count < 3)
        {
            InvokeRepeating("Spawn", 5, 5);
        }     
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        x = Random.Range(0, 4);
        if (x <= 1)
        {
            pos = Vector2.up * 5;
        }
        else if (x > 1 && x <= 2)
        {
            pos = Vector2.right * 5;
        }
        else if (x > 2 && x <= 3)
        {
            pos = Vector2.down * 5;
        }
        else if (x > 3 && x <= 4)
        {
            pos = Vector2.left * 5;
        }

        GameObject new_bandit = GameObject.Instantiate(bandit);
        new_bandit.transform.position = new Vector2(pos.x, pos.y);
    }
}
 