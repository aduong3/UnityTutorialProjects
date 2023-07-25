using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public int spawnCount = 5;
    public float spawnOffset = 1.5f;


    void Start()
    {
        if (spawnPrefab != null)
        {
            SpawnEnemies();
        }
        else
        {
            Debug.LogError("Error! Prefab is missing!");
        }
    }
    void SpawnEnemies()
    {
        for(int i = 0; i < spawnCount; i++)
        {
            float xPos = i * spawnOffset; //x position offset for each iteration of i
            //each i is a new enemy spawned
            Vector3 spawnPos = new Vector3(xPos, 0, 0); //create a vector where 
            //it uses the x position so it spawns at that new x.
            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
            //Instantiate = spawn or add
            //(GameObject, Position, Rotation)
            //Quaternion.identity means no rotation
        }
    }

}