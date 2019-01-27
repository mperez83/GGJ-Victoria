using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsToText : MonoBehaviour
{

    Text txt;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = player.GetComponent<PlayerShieldSword>().pts.ToString(); 
    }
}
