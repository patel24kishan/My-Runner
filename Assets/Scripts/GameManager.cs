using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int lives = 0;
    [SerializeField] int scores = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int value)
    {
        lives += value;
        if (lives <= 0) {
            Debug.Log("Game Over!");
        }

        Debug.Log("Lives="+lives);
    }

    public void UpdateScore(int value)
    {
        scores += value;
        Debug.Log("scores=" + scores);
    }

}
