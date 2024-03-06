using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Player reference for camera movement
    public Transform player;

    //GameOver UI reference
    public GameObject gameOverUI;

    private void Start()
    {
        //Disable GameOver UI
        gameOverUI.SetActive(false);
    }

    void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            //Set camera poistion IF the player's Y is greater
            Vector3 newPos = new Vector3(0f, player.position.y, -10f);

            transform.position = newPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy Player and Enable GameOver UI
            Destroy(collision.gameObject);

            gameOverUI.SetActive(true);
        }
    }
}
