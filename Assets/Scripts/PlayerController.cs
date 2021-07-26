using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isRight = true;
    public static Rigidbody2D rb2D;

    
    private float movInput;

    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    
    void FixedUpdate()
    {
        movInput = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(movInput * speed, rb2D.velocity.y);
        
        if(isRight == false && movInput > 0)
        {
            FlipX();
        }
        else if(isRight == true && movInput < 0)
        {
            FlipX();
        }
    }

    void FlipX()
    {
        isRight = !isRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
