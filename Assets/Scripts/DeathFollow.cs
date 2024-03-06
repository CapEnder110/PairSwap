using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFollow : MonoBehaviour
{
    //Player refernce for movement
    public Transform player;

    void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            //Move platform destroyer as player moves, disabling Z movement
            Vector3 newPos = new Vector3(0f, player.position.y - 9.5f, -10f);

            transform.position = newPos;
        }
    }
}
