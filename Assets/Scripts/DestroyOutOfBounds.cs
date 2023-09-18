using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] float topBound = 30f;
    [SerializeField] float lowerBound = -30f;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z<lowerBound )
        {
            gameManager.UpdateLives(-1);
            Destroy(gameObject);
        }
        
    }
}
