using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public float minSpawnDelay = 4f;
    public float maxSpawnDelay = 7f;

    [Header("References")]
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

    void Spawn()
    {
        var objectToSpawn = gameObjects[Random.Range(0, gameObjects.Length)];
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

    void Update()
    {

    }
}
