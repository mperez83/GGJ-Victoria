using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Image m_Image;
    public TMP_Text m_score;
    private int numScore;

    public float horizontalSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        numScore = 0;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        Debug.Log("-> " + m_Image.sprite.ToString() + " <-");
        if(other.CompareTag("Blue"))
        {
            if(m_Image.sprite.ToString() == "600px-Ski_trail_rating_symbol-blue_square.svg (UnityEngine.Sprite)") //might have to delete .svg
            {
                numScore += 10;
                m_score.text = "Score: " + numScore.ToString();
            }
            else
            {
                numScore -= 5;
                m_score.text = "Score: " + numScore.ToString();
            }
        }

        else if(other.CompareTag("Smile"))
        {
            if(m_Image.sprite.ToString() == "Square-PhotoWithout (UnityEngine.Sprite)")
            {
                numScore += 10;
                m_score.text = "Score: " + numScore.ToString();
            }
            else
            {
                numScore -= 5;
                m_score.text = "Score: " + numScore.ToString();
            }
        }
    }
}
