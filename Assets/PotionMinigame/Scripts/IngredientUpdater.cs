using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientUpdater : MonoBehaviour
{
    Image m_Image;
    public Sprite m_sprite1;
    public Sprite m_sprite2;
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
        int rand = Random.Range(0, 2);
        //Debug.Log(rand);
        if (rand == 0)
        {
            m_Image.sprite = m_sprite1;
            //Debug.Log(m_Image.sprite); //m_Image.sprite returns sprite name
        }
        else if (rand == 1)
        {
            m_Image.sprite = m_sprite2;
        }
    }

}

