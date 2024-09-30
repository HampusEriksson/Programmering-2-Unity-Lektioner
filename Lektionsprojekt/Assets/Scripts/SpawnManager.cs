using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Attribut
    public GameObject[] enemyPrefabs;
    private float delay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", delay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]);
        delay *= 0.95f;
        delay = Mathf.Max(0.1f, delay);
        Invoke("SpawnEnemy", delay);
    }
}
