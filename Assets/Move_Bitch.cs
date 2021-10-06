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
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if(horizontal == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            
        }
       

        if(horizontal == 1)
        {
            transform.localScale = new Vector3(1,1,1);
            
        }
       
        

        rb.velocity = new Vector2(horizontal * moveSpeedX, vertical * moveSpeedY);
        
        
        //float xSpeed = 5.0f;
        //float ySpeed = 5.0f;       
    }


    public void Button_press()
    {
        rb.velocity = new Vector2(horizontal, vertical * moveSpeedY);
        Debug.Log("dijd");

    }
}
