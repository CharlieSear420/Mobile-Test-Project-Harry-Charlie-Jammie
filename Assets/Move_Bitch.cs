using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Bitch : MonoBehaviour
{
    Rigidbody2D rb;
    bool up = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        
        Vector2 velocity = rb.velocity;

        velocity.x = 0;
        velocity.y = 7;


        float xSpeed = 5.0f;
        float ySpeed = 5.0f;

        if (up == true)
        {
            rb.velocity = velocity;
        }


    }


    public void Button_press()
    {

    }
}
