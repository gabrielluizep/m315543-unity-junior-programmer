using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAnimal () {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalsPrefabs.Length);

        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
