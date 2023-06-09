using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    private GameObject newEnemy;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewEnemy", 0f, 1f);
    }

    // Update is called once per frame
    private void SpawnNewEnemy()
    {
        randomSpawnZone = Random.Range(0, 4);

        switch (randomSpawnZone)
        {
            case 0:
                randomXposition = Random.Range(-11f, -10f);
                randomYposition = Random.Range(-8f, -8f);
                break;
            case 1:
                randomXposition = Random.Range(-10f, 10f);
                randomYposition = Random.Range(-7f, -8f);
                break;
            case 2:
                randomXposition = Random.Range(10f, 11f);
                randomYposition = Random.Range(-8f, 8f);
                break;
            case 3:
                randomXposition = Random.Range(-10f, 10f);
                randomYposition = Random.Range(7f, 8f);
                break;
        }

        spawnPosition = new Vector3(randomXposition, randomYposition, 0f);
        newEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
