using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float horizontalSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalForce = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalForce * horizontalSpeed, rb.velocity.y);
    }
}
