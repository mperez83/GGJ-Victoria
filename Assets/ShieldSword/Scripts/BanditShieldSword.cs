using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditShieldSword : MonoBehaviour
{
    public Vector2 dir;
    public float speed;
    public float z_coord;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, z_coord);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -dir * Time.deltaTime);
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
 