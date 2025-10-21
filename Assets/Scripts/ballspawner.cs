using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab; // Assign in Inspector
    public float spawnInterval = 2f; // Time between spawns
    public float spawnRangeY = 4f; // Vertical random range

    void Start()
    {
        // Repeat the SpawnBall function every 'spawnInterval' seconds
        InvokeRepeating("SpawnBall", 1f, spawnInterval);
    }

    void SpawnBall()
    {
        float randomY = Random.Range(-spawnRangeY, spawnRangeY); // random vertical position
        Vector2 spawnPos = new Vector2(10f, randomY); // right edge of screen
        Instantiate(ballPrefab, spawnPos, Quaternion.identity);
    }
}
