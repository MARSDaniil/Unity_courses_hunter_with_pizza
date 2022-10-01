using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 25;
  

    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void spawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
       
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
