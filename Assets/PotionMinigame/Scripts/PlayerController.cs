using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Image m_Image;
    public TMP_Text m_score;
    public AudioClip m_badSound;
    public AudioClip m_goodSound;
    private float time;
    private int numScore;

    public float horizontalSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
        numScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Move();
        CheckEndState();
    }

    void Move()
    {
        float horizontalForce = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalForce * horizontalSpeed, rb.velocity.y);
    }

    void CheckEndState()
    {
        if(time > 60 && numScore < 200) //failed level
        {
            SceneManager.LoadScene("Lose");
        }
        else if(time > 60 && numScore > 200)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        CollisionComparison(other, other.tag);
    }

    void CollisionComparison(Collider2D othr, string tag)
    {
        if (othr.CompareTag(tag))
        {
            if (m_Image.sprite.ToString() == tag + " (UnityEngine.Sprite)")
            {
                AudioSource.PlayClipAtPoint(m_goodSound, transform.position, 1);
                numScore += 10;
                m_score.text = "Score: " + numScore.ToString();
            }
            else
            {
                AudioSource.PlayClipAtPoint(m_badSound, transform.position, 1);
                numScore -= 5;
                m_score.text = "Score: " + numScore.ToString();
            }
        }
    }
}
