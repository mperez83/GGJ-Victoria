using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientUpdater : MonoBehaviour
{
    Image m_Image;
    public Sprite m_sprite1;
    public Sprite m_sprite2;

    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("ChangeImage", .5f, .5f);
    }

    void ChangeImage()
    {
        Debug.Log(m_Image.sprite);
        if (m_Image.sprite = m_sprite2)
        {
            Debug.Log("sprite2");
            m_Image.sprite = m_sprite1;
        }
        else if (m_Image.sprite = m_sprite1)
        {
            Debug.Log("sprite1");
            m_Image.sprite = m_sprite2;
        }
    }
}
