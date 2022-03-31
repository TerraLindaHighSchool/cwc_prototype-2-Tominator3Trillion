using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastSpawned = 0f;
    public float spawnDelay = 1.25f;

    void Start() {
        timeSinceLastSpawned = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - timeSinceLastSpawned > spawnDelay)
        {
            timeSinceLastSpawned = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
