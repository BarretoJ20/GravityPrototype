using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public bool onTop;

    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerController.rb2D.gravityScale *= -1;
            FlipY();
        }

        //mobile
        /*if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            PlayerController.rb2D.gravityScale *= -1;
            FlipY();
        }
        //
        */
       

       

    }

    void FlipY()
    {
        onTop = !onTop;
        Vector3 Scaler = transform.localScale;
        Scaler.y *= -1;
        transform.localScale = Scaler;
    }

    public void ChangeGravityM()
    {
        //funcao para trocar a gravidade no mobile
        PlayerController.rb2D.gravityScale *= -1;
        FlipY();

    }
   

}
