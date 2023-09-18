using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 3.5f;
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGameOver==false) {
             transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
