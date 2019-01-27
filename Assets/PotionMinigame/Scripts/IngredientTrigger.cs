using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientTrigger : MonoBehaviour
{
    public AudioClip m_splatFrog;
    public AudioClip m_splatPotion;
    public AudioSource source;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if(other.CompareTag("Ground"))
        {
            if(gameObject.tag == "Frog")
            {
                source.PlayOneShot(source.clip);
                rend.enabled = false;
                Destroy(gameObject, m_splatFrog.length);
            }
            else if(gameObject.tag == "Potion_1")
            {
                source.PlayOneShot(source.clip);
                rend.enabled = false;
                Destroy(gameObject, m_splatPotion.length);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
