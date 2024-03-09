using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision)
    {
        //If player goes off screen on right side, teleport to left side
        if (collision.gameObject.layer == 9)
        {
            transform.position = new Vector3(-16.18f,transform.position.y,transform.position.z);
        }

        //If player goes off screen on left side, teleport to right side
        if (collision.gameObject.layer == 10)
        {
            transform.position = new Vector3(16.18f, transform.position.y, transform.position.z);
        }
    }
}
