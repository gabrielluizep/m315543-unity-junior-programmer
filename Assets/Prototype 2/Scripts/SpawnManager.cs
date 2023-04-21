using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    public float spawnMinZ = -1;
    public float spawnMaxZ = 15;

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
        Vector3 spawnPos ;
        Quaternion rotation;

        switch(Random.Range(0,3)) {
            case 0:
                spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                rotation = Quaternion.Euler(0, 180, 0);
                break;
            case 1:
                spawnPos = new Vector3(spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));
                rotation = Quaternion.Euler(0, 270, 0);
                break;
            case 2:
                spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));
                rotation = Quaternion.Euler(0, 90, 0);
                break;
            default:
                Debug.Log("Error");
                spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                rotation = Quaternion.Euler(0, 180, 0);
                break;
        }
        
        int animalIndex = Random.Range(0, animalsPrefabs.Length);

        Instantiate(animalsPrefabs[animalIndex], spawnPos, rotation);
    }
}
