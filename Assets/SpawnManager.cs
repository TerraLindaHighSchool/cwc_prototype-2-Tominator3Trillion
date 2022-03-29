using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs = new GameObject[3];
    public float maxXDist = 10f;

    public float spawnInterval = 1.5f;
    

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2f, spawnInterval);
    }
    

    void SpawnRandomAnimal()
    {
        // random location from -maxXDist to maxXDist
        float xPos = Random.Range(-maxXDist, maxXDist);
        // random animal from the animalPrefabs array
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // instantiate the animal at the random location
        Instantiate(animalPrefabs[animalIndex], new Vector3(xPos, transform.position.y, transform.position.z), animalPrefabs[animalIndex].transform.rotation);

        
    }
}
