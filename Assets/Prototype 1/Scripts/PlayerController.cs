using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float speed = 10f;
    [SerializeField] float turnSpeed = 1f;
    private float xInput;
    private float yInput;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       xInput=Input.GetAxis("Horizontal");
       yInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * xInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed*yInput);

       /* if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            moveForward();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            moveRight();
        }*/
    }
    public void moveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void moveRight()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * xInput);
    }
}
