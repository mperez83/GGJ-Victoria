using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerShieldSword : MonoBehaviour
{
    public GameObject arrow;
    public GameObject bandit;
    int bandit_count;
    int arr_count;
    int x;
    Vector2 pos;
    Vector2 dir;
    int toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle = Random.Range(0, 2);

    }

    // Update is called once per frame
    void Update()
    {
        bandit_count = GameObject.FindGameObjectsWithTag("Enemy").Length;
        arr_count = GameObject.FindGameObjectsWithTag("Projectile").Length;
        if (toggle == 0 && bandit_count == 1 && arr_count < 2)
        {
            SpawnBandit();
        }
        else if (toggle == 1 && arr_count == 1 && bandit_count < 2)
        {
            SpawnArrow();
        }
    }

    void setPosAndDir()
    {
        x = Random.Range(0, 5);
        if (x <= 1)
        {
            pos = Vector2.up * 5;
            dir = Vector2.down;
        }
        else if (x > 1 && x <= 2)
        {
            pos = Vector2.right * 6.5f;
            dir = Vector2.left;
        }
        else if (x > 2 && x <= 3)
        {
            pos = Vector2.down * 5;
            dir = Vector2.up;
        }
        else if (x > 3 && x <= 4)
        {
            pos = Vector2.left * 6.5f;
            dir = Vector2.right;
        }
    }

    void SpawnBandit()
    {
        setPosAndDir();
        GameObject new_bandit = GameObject.Instantiate(bandit);
        new_bandit.transform.position = new Vector2(pos.x, pos.y);
        new_bandit.GetComponent<BanditShieldSword>().dir = dir;
        toggle = Random.Range(0, 2);
    }

    void SpawnArrow()
    {
        setPosAndDir();
        GameObject new_arr = GameObject.Instantiate(arrow);
        new_arr.transform.position = new Vector2(pos.x, pos.y);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        new_arr.GetComponent<Arrow>().dir = dir;
        toggle = Random.Range(0, 2);
    }
}
