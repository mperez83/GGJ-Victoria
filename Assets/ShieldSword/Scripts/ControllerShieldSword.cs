using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerShieldSword : MonoBehaviour
{
    public GameObject arrow;
    public GameObject bandit;
    int bandit_count;
    int arr_count;
    int x;
    Vector2 pos;
    Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bandit_count = GameObject.FindGameObjectsWithTag("Enemy").Length;
        arr_count = GameObject.FindGameObjectsWithTag("Projectile").Length;
        if (bandit_count + arr_count <= 5)
        {
            if (bandit_count < arr_count)
            {
                SpawnBandit();
            }
            else
            {
                SpawnArrow();
            }
            
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
        Debug.Log(x);
    }

    void SpawnBandit()
    {
        setPosAndDir();
        GameObject new_bandit = GameObject.Instantiate(bandit);
        new_bandit.transform.position = new Vector2(pos.x, pos.y);
        new_bandit.GetComponent<BanditShieldSword>().dir = dir;
        //GameObject.Instantiate(new_bandit);
    }

    void SpawnArrow()
    {
        setPosAndDir();
        GameObject new_arr = GameObject.Instantiate(arrow);
        new_arr.transform.position = new Vector2(pos.x, pos.y);
        new_arr.GetComponent<Arrow>().dir = dir;
        //new_arr.transform.rotation = Quaternion.LookRotation(Vector3.forward, dir);
    }
}
