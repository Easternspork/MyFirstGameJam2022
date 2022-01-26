using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnInterval = 5f;
    public float spawnDelay = 0f;
    public GameObject enemyPrefab;

    public float spawnTopLimit;
    public float spawnBottomLimit;
    public float spawnRightLimit;
    public float spawnLeftLimit;
    public float outerrim = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval + spawnDelay);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(spawnLeftLimit - outerrim, spawnRightLimit + outerrim);
        float randomY = Random.Range(spawnBottomLimit - outerrim, spawnTopLimit + outerrim);

        // new random coord if the coord is in the inner box
        while (randomX < spawnRightLimit && randomX > spawnLeftLimit && randomY < spawnTopLimit && randomY > spawnBottomLimit)
        {
            randomX = Random.Range(spawnLeftLimit - outerrim, spawnRightLimit + outerrim);
            randomY = Random.Range(spawnBottomLimit - outerrim, spawnTopLimit + outerrim);
        }

        Vector2 randomPosition = new Vector2(randomX, randomY);

        Instantiate(enemyPrefab, randomPosition, transform.rotation);
    }
}
