using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGenerator : MonoBehaviour
{
    //Prefab reference of platforms
    public GameObject platform;

    //Determine Level values and how many platforms are loaded in on Play
    public int numberOfPlatforms;
    public float levelWidth = 7f;

    public float minY = 0.2f;
    public float maxY = 1.5f;
    
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            //Randomly spawns platforms when game starts
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platform, spawnPosition, Quaternion.identity);
        }
    }

    public void Restart()
    {
        //Restart code for GameOver
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
