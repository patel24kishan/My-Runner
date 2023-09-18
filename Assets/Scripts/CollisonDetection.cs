using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonDetection : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                if (gameObject.tag == "life")
                    gameManager.UpdateLives(1);
                else
                gameManager.UpdateLives(-1);

            Destroy(gameObject);
        }
        else if (gameObject.tag == "Animal" &&other.CompareTag("Food"))
        {
            gameManager.UpdateScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
