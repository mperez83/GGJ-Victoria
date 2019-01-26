using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSwordScript : MonoBehaviour
{
    bool attack;
    bool defend;
    Vector2 dir;
    RaycastHit2D atk_dir;
    
    // Start is called before the first frame update
    void Start()
    {
        attack = false;
        defend = true;
    }

    // Update is called once per frame
    void Update()
    {
        Point();
        Sword();
    }

    void Point()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Up");
            dir = transform.TransformDirection(Vector2.up) * 2;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Down");
            dir = transform.TransformDirection(Vector2.down) * 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Debug.Log("Right");
            dir = transform.TransformDirection(Vector2.right) * 2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Debug.Log("Left");
            dir = transform.TransformDirection(Vector2.left) * 2;
        }
    }

    void Sword()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Vector2 start_pos = new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y);
            attack = true;
            defend = false;
            Debug.DrawRay(start_pos, dir, Color.red, 0.5f);
            atk_dir = Physics2D.Raycast(start_pos, dir, 2f);
            if (atk_dir.collider != null)
            {
                if (atk_dir.collider.gameObject.CompareTag("Enemy"))
                {
                    Debug.Log("hit enemy");
                }
            }
            //Debug.Log("Attack " + attack);
            //Debug.Log("Defend " + defend);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            attack = false;
            defend = true;
            //Debug.Log("Attack " + attack);
            //Debug.Log("Defend " + defend);
        }
    }

    
}
