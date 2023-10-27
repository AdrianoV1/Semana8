using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1.5f;

    private float nextSpawnTime;

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {

            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
