using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstacle;

    private float timeLeftUntilSpawn;
    public float maxTimeBetweenSpawn;

    // Update is called once per frame
    void Update()
    {
        if (timeLeftUntilSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeLeftUntilSpawn = Random.Range(1,maxTimeBetweenSpawn);
        } else
        {
            timeLeftUntilSpawn -= Time.deltaTime;
        }
    }
}
