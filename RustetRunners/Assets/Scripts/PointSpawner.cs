using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{

    public GameObject obstacle;

    private float timeLeftUntilSpawn;
    public float maxTimeBetweenSpawn;
    private const int maxHeight = 6;
    private const int minHeight = 3;

    // Update is called once per frame
    void Update()
    {
        if (timeLeftUntilSpawn <= 0)
        {
            Instantiate(obstacle, new Vector2(11.59f, Random.Range(minHeight, maxHeight)), Quaternion.identity);
            timeLeftUntilSpawn = Random.Range(1,maxTimeBetweenSpawn);
        } else
        {
            timeLeftUntilSpawn -= Time.deltaTime;
        }
    }
}
