using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawner;
    public float xMax = 20.0f;
    public float xMin = -20.0f;
    public float spawnPosZ = 20.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int animalIndex = Random.Range(0, spawner.Length);
        Vector3 spawnPos = new Vector3(Random.Range(xMin, xMax), transform.position.y, spawnPosZ);
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(spawner[animalIndex], spawnPos, spawner[animalIndex].transform.rotation);
        }
    }
}
