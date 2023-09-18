using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMnger : MonoBehaviour
{
    public GameObject[] spawnPrefab;
    [SerializeField] float invokeStart = 2f;
    [SerializeField] float invokeDelay = 5f;
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", invokeStart, invokeDelay);
        controller = GameObject.Find("GameController").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnAnimal()
    {
        if (controller.isGameOver == false)
        {
            int prefabIdx = Random.RandomRange(0, 3);
            Vector3 SpawnLocation = new Vector3(Random.Range(30, 35), 0, 0);
            Instantiate(spawnPrefab[prefabIdx], SpawnLocation, spawnPrefab[prefabIdx].transform.rotation);
        }
    }

   
}
