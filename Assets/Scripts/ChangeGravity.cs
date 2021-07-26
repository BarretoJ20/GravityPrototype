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

    }

    void FlipY()
    {
        onTop = !onTop;
        Vector3 Scaler = transform.localScale;
        Scaler.y *= -1;
        transform.localScale = Scaler;
    }
}
