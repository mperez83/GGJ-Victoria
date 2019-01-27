using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientUpdater : MonoBehaviour
{
    Image m_Image;
    public Sprite[] pictures;
    //public Sprite m_sprite1;
    //public Sprite m_sprite2;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 300)
        {
            ++counter;
        }
        else
        {
            ChangeImg();
            counter = 0;
        }
    }

    void ChangeImg()
    {
        int rand = Random.Range(0, 5);
        //Debug.Log(rand);
        if (rand == 0)
        {
            //m_Image.sprite = m_sprite1;
            m_Image.sprite = pictures[0];
        }
        else if (rand == 1)
        {
            //m_Image.sprite = m_sprite2;
            m_Image.sprite = pictures[1];
        }
        else if (rand == 2)
        {
            //m_Image.sprite = m_sprite2;
            m_Image.sprite = pictures[2];
        }
        else if (rand == 3)
        {
            //m_Image.sprite = m_sprite2;
            m_Image.sprite = pictures[3];
        }
        else if (rand == 4)
        {
            //m_Image.sprite = m_sprite2;
            m_Image.sprite = pictures[4];
        }
    }

}

