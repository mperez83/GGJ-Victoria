using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float horizontalSpeed = 10.0f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalForce = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(horizontalForce * horizontalSpeed, rb2d.velocity.y);
    }
}
