using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 6;
    private float spawnPos = 20;
    private float startDelay = 2;
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

    void SpawnRandomAnimal(){
        Vector3 spawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPos);
        
        Vector3 spawnPosZ = new Vector3(-spawnPos,
            0, Random.Range(-spawnRangeZ, spawnRangeZ));

            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex]  , spawnPosX,
            animalPrefabs[animalIndex].transform.rotation);

            Instantiate(animalPrefabs[animalIndex], spawnPosZ, Quaternion.Euler(0, 90, 0));

        
    }
}
