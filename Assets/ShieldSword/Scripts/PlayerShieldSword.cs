using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldSword : MonoBehaviour
{
    public Sprite dfd;
    public Sprite atk;
    private SpriteRenderer sprite_render;
    public int pts;
    AudioSource swipe;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite_render = this.GetComponent<SpriteRenderer>();
        swipe = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Point();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            sprite_render.sprite = atk;
            swipe.Play();
            this.GetComponent<BoxCollider2D>().size = new Vector2(0.3790514f, 0.3276514f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.08952573f, 0.1489272f);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            sprite_render.sprite = dfd;
            this.GetComponent<BoxCollider2D>().size = new Vector2(0.4999112f, 0.2095523f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.002238154f, 0.05352981f);
        }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (sprite_render.sprite == dfd)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                pts -= 5;
            }
        }
        if (sprite_render.sprite == atk)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                pts += 5;
            }
            if (collision.gameObject.CompareTag("Projectile"))
            {
                pts -= 10;
            }
        }
    }
}
