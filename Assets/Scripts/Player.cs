using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    //Rigidbody Reference
    Rigidbody2D RB;

    //Movement
    float movement = 0f;
    public float moveSpeed = 10f;

    //Score
    public Text score;
    private float topScore = 0f;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //Gets input for movement
        movement = Input.GetAxis("Horizontal") * moveSpeed;

        //Increase score based on Player Y value, rounded up
        if (RB.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        score.text = "Score: " + Mathf.Round(topScore).ToString();
    }

    void FixedUpdate()
    {
        //Sets movement speed
        Vector2 velocity = RB.velocity;

        velocity.x = movement;
        RB.velocity = velocity;
    }
}
