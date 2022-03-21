using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] golemPrefabs;
    private Vector3 spawnPosition;

    private float xRange = 15f;
    private float spawnZ = 25f;
    private float startTime = 2f;
    private float repeatRate = 1.5f;

    private float randomX = 2f;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGolem", startTime, repeatRate);
    }



    public Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, spawnZ);
    }


    public void SpawnGolem()
    {
        int randomIndex = Random.Range(0, golemPrefabs.Length);
        spawnPosition = RandomSpawnPosition();
        Instantiate(golemPrefabs[randomIndex], spawnPosition,
            golemPrefabs[randomIndex].transform.rotation);
    }
}
