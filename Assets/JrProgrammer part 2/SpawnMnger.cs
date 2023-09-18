using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMnger : MonoBehaviour
{
    public GameObject spawnPrefab;
    [SerializeField] float invokeStart = 2f;
    [SerializeField] float invokeDelay = 1.25f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", invokeStart, invokeDelay);
        InvokeRepeating("SpawnLives", 5, 10);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnAnimal()
    {
        Vector3 SpawnLocation = new Vector3(Random.Range(-20, 20), 0, 20);
        Instantiate(spawnPrefab, SpawnLocation, spawnPrefab.transform.rotation);
    }

   
}
