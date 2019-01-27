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
    float z_coord;
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
            z_coord = 180;
        }
        else if (x > 1 && x <= 2)
        {
            pos = Vector2.right * 6.5f;
            z_coord = 90;
        }
        else if (x > 2 && x <= 3)
        {
            pos = Vector2.down * 5;
            z_coord = 0;
        }
        else if (x > 3 && x <= 4)
        {
            pos = Vector2.left * 6.5f;
            z_coord = -90;
        }
    }

    void SpawnBandit()
    {
        setPosAndDir();
        GameObject new_bandit = GameObject.Instantiate(bandit);
        new_bandit.transform.position = new Vector2(pos.x, pos.y);
        new_bandit.GetComponent<BanditShieldSword>().dir = Vector2.down;
        new_bandit.GetComponent<BanditShieldSword>().z_coord = z_coord;
        toggle = Random.Range(0, 2);
    }

    void SpawnArrow()
    {
        setPosAndDir();
        GameObject new_arr = GameObject.Instantiate(arrow);
        new_arr.transform.position = new Vector2(pos.x, pos.y);
        new_arr.GetComponent<Arrow>().dir = Vector2.down;
        new_arr.GetComponent<Arrow>().z_coord = z_coord;
        toggle = Random.Range(0, 2);
    }
}
