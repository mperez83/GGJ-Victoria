using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientUpdater : MonoBehaviour
{
    Image m_Image;
    public Sprite[] pictures;
    //private int counter = 0;
    public Image timerBar;
    public float maxTime = 5f;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;   
        }
        else
        {
            ChangeImg();
            timeLeft = maxTime;
        }
    }

    void ChangeImg()
    {
        int rand = Random.Range(0, 4);
        if (rand == 0)
        {
            m_Image.sprite = pictures[0];
        }
        else if (rand == 1)
        {
            m_Image.sprite = pictures[1];
        }
        else if (rand == 2)
        {
            m_Image.sprite = pictures[2];
        }
        else if (rand == 3)
        {
            m_Image.sprite = pictures[3];
        }
        //else if (rand == 4)
        //{
          // m_Image.sprite = pictures[4];
        //}
    }

}

