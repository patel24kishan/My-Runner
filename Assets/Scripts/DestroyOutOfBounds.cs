using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] float topBound = 35;
    [SerializeField] float lowerBound = -5f;
    [SerializeField] int obstaclePoint = 1;
    void Start()
    {
        GameController controller = GameObject.FindAnyObjectByType<GameController>();
        controller.UpdateScore(obstaclePoint);
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.x<lowerBound )
        {
            Destroy(gameObject);
        }
        
    }
}
