using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabPlataformas;
    public GameObject prefabPickUp;
    public float randomRange = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlataformas", 0f, 5f);
        InvokeRepeating("SpawnPickUp", 0f, 5f);
    }

    void SpawnPlataformas()
    {
        Vector3 spawnPosition;
        spawnPosition.x = transform.position.x;
        spawnPosition.y = Random.Range(3.5f, -3.5f);
        spawnPosition.z = transform.position.z;
        Instantiate(prefabPlataformas, spawnPosition, Quaternion.identity);
    }

    void SpawnPickUp()
    {
        Vector3 spawnPosition;
        spawnPosition.x = transform.position.x;
        spawnPosition.y = Random.Range(3.5f, -3.5f);
        spawnPosition.z = transform.position.z;
        Instantiate(prefabPickUp, spawnPosition, Quaternion.identity);
    }

}
