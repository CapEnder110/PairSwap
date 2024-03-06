using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    //How bouncy is the platform
    public float jumpForce = 10f;

    void OnCollisionEnter2D (Collision2D collision)
    {
        //Makes platforms bouncy
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D RB = collision.collider.GetComponent<Rigidbody2D>();

            if (RB != null)
            {
               Vector2 velocity = RB.velocity;

                velocity.y = jumpForce;
                RB.velocity = velocity;
            }
        }
    }
}
