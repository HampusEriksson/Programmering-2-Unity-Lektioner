using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Attribut
    public GameObject[] enemyPrefabs;
    private float delay = 2f;

    public GameObject[] powerupPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", delay);
        SpawnPowerup();
    }

    void SpawnEnemy()
    {
        //GameObject newObject = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]);
        int index = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[index], new Vector3(Random.Range(-8,8), Random.Range(-5, 5), 0), enemyPrefabs[index].transform.rotation);
        delay *= 0.95f;
        delay = Mathf.Max(0.1f, delay);
        Invoke("SpawnEnemy", delay);
    }

    void SpawnPowerup()
    {
        //GameObject newObject = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]);
        int index = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[index], new Vector3(Random.Range(-8, 8), Random.Range(-5, 5), 0), powerupPrefabs[index].transform.rotation);
        Invoke("SpawnPowerup", 5f);
    }
}
