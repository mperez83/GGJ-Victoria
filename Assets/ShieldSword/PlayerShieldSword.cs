using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldSword : MonoBehaviour
{
    /// <summary>
    /// ADD POINTS
    /// </summary>

    public Sprite dfd;
    public Sprite atk;
    private SpriteRenderer sprite_render;
    
    // Start is called before the first frame update
    void Start()
    {
        //attack = false;
        //defend = true;
        sprite_render = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Point();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            sprite_render.sprite = atk;
            this.GetComponent<BoxCollider2D>().size = new Vector2(0.3790514f, 0.3276514f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.08952573f, 0.1489272f);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            sprite_render.sprite = dfd;
            this.GetComponent<BoxCollider2D>().size = new Vector2(0.4999112f, 0.4340281f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.002238154f, -0.01063752f);
        }
        //Sword();
        //Hurt();
    }

    void Point()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 180);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -90);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 90);
        }
    }

    //void Sword()
    //{
    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        sprite_render.sprite = atk;
    //        this.GetComponent<BoxCollider2D>().size = new Vector2(0.3790514f, 0.3276514f);
    //        this.GetComponent<BoxCollider2D>().offset = new Vector2(0.08952573f, 0.1489272f);
    //    }

    //    if (Input.GetKeyUp(KeyCode.Q))
    //    {
    //        sprite_render.sprite = dfd;
    //        this.GetComponent<BoxCollider2D>().size = new Vector2(0.4999112f, 0.4340281f);
    //        this.GetComponent<BoxCollider2D>().offset = new Vector2(0.002238154f, -0.01063752f);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (sprite_render.sprite == dfd)
        {
            Debug.Log(">:)");
        }
        if (sprite_render.sprite == atk)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Ha, YES!");
            }
            if (collision.gameObject.CompareTag("Projectile"))
            {
                Debug.Log("what the fuck?");
            }
        }
    }

    //void Hurt()
    //{
    //    if (defend == false)
    //    {
    //        Debug.Log("oof");
    //    }
    //}
}
