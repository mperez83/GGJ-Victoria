using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditShieldSword : MonoBehaviour
{
    public Vector2 dir;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * dir * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("aaahhh!!! DIE!!!!!!!!!!!!!!!!!!!");
            Destroy(this.gameObject);
        }
    }
}
 