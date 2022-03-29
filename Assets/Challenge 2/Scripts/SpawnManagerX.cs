﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4f;


    void Start() {
        spawnInterval = Mathf.Floor(Random.Range(3.0f, 5.0f));
    }

    void Update() {
        if(Time.time > startDelay) {
            if(Mathf.Floor(Time.time) % spawnInterval == 0) {
                SpawnRandomBall();
                spawnInterval = Mathf.Floor(Random.Range(3.0f, 5.0f));
            }
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
    }

}