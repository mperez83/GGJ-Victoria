using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    Vector2 pos;
    public Vector2 dir;
    public float z_coord;
   
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(dir.x, dir.y, z_coord);
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
            Destroy(this.gameObject);
        }
    }
}
