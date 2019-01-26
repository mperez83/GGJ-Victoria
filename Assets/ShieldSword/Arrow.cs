using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    Vector2 pos;
    int x;
    public GameObject arr;
    Vector2 dir;
   
    // Start is called before the first frame update
    void Start()
    {
        setPosAndDir();
        arr.transform.position = pos;
        //int count = GameObject.FindGameObjectsWithTag("Enemy").Length;
        //if (count < 3)
        //{
        //    InvokeRepeating("Spawn", 5, 5);
        //}
    }

    // Update is called once per frame
    void Update()
    {    
        arr.transform.Translate(speed * dir * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("aaahhh!!! DIE!!!!!!!!!!!!!!!!!!!");
        }
        //Debug.Log(collision.gameObject.name);
    }

    void setPosAndDir()
    {
        x = Random.Range(0, 4);
        if (x <= 1)
        {
            pos = Vector2.up * 5;
            dir = Vector2.down;
        }
        else if (x > 1 && x <= 2)
        {
            pos = Vector2.right * 5;
            dir = Vector2.left;
        }
        else if (x > 2 && x <= 3)
        {
            pos = Vector2.down * 5;
            dir = Vector2.up;
        }
        else if (x > 3 && x <= 4)
        {
            pos = Vector2.left * 5;
            dir = Vector2.right;
        }
    }
}
