using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Bitch : MonoBehaviour
{
    public Rigidbody2D rb;

    public float horizontal;
    public float vertical;
    public float moveSpeedX;
    public float moveSpeedY;
    public bool jump = false;
    
    private Touch touch;
    private float speedModifier;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speedModifier = 0.01f;
    }

    
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        
       

        
       
        

        //rb.velocity = new Vector2(horizontal * moveSpeedX, vertical * moveSpeedY);
        print (horizontal);
        
        
        //float xSpeed = 5.0f;
        //float ySpeed = 5.0f;     

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier
                );
            }
        }  
    }
  

    public void Button_press()
    {
        rb.velocity = new Vector2(horizontal, 5);
        Debug.Log("I am jumping!");

    }

    public void Button_Right()
    {
        rb.velocity = new Vector2(6, vertical);
        Debug.Log("I am moving right");
    }

    public void Button_Left()
    {
        rb.velocity = new Vector2(-6, vertical);
        Debug.Log("I am moving left");
    }
}


    

