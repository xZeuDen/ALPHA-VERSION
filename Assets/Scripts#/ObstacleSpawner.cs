using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;  // Array to hold multiple obstacle prefabs
    public float spawnDistanceMin = 10f;   // Minimum distance in front of the player
    public float spawnDistanceMax = 30f;   // Maximum distance in front of the player
    public float minSpawnTime = 2f;        // Minimum time between spawns
    public float maxSpawnTime = 3.5f;      // Maximum time between spawns
    public Transform player;               // Reference to the player’s transform

    private void Start()
    {
        
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            
            for (int i = 0; i < 1; i++)
            {
                // Wait for a random amount of time before spawning the next obstacle
                float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
                yield return new WaitForSeconds(spawnTime);

                // Calculate a random distance in front of the player
                float spawnDistance = Random.Range(spawnDistanceMin, spawnDistanceMax);

                // Get the spawn position in front of the player
                Vector3 spawnPosition = player.position + player.forward * spawnDistance;
                spawnPosition.x += Random.Range(-2.45f, -8.44f);
                spawnPosition.y = 1f;

                // Randomly select an obstacle prefab from the array
                int randomIndex = Random.Range(0, obstaclePrefabs.Length);
                GameObject selectedObstacle = obstaclePrefabs[randomIndex];

                // Instantiate the selected obstacle at the spawn position
                Instantiate(selectedObstacle, spawnPosition, Quaternion.identity);

            }
        }
    }

    }
