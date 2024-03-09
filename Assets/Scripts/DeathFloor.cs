using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFloor : MonoBehaviour
{
    //Player and Platform references
    public GameObject player;
    public GameObject platform;
    public GameObject superPlatform;
    private GameObject newPlat;

    //Height of new platform spawns
    public float minY = 0.2f;
    public float maxY = 1.5f;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        //Platform Destroyer takes platforms it hits and moves them up to a new random location
        if (collision.gameObject.layer == 7)
        {
            //Random chance for Super Platform
            if (Random.Range(1, 10) == 1)
            {
                //Destroies Normal Platform, spawns Super Platform
                Destroy(collision.gameObject);

                Instantiate(superPlatform, new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (16 + Random.Range(minY, maxY))), Quaternion.identity);
            }

            else
            {
                //Moves Normal Platform
                collision.gameObject.transform.position =  new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (16 + Random.Range(minY, maxY)));
            }
        }

        else if (collision.gameObject.layer == 8)
        {
            //Random chance to keep Super Platform
            if (Random.Range(1, 10) == 1)
            {
                //Moves Super Platform
                collision.gameObject.transform.position = new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (16 + Random.Range(minY, maxY)));
            }

            else
            {
                //Destroies Super Platform, Spawns Normal Platform
                Destroy(collision.gameObject);

                Instantiate(platform, new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (16 + Random.Range(minY, maxY))), Quaternion.identity);
            }
        }
    }
}
