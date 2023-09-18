﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public Transform propellor;

    [SerializeField] float speed = 1f;
    [SerializeField] float rotationSpeed=1f; 
    [SerializeField] float propellorSpeed = 5f;
    private float verticalInput;
    private float horizontalInput;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
   

    
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime*verticalInput);

        //Rotate Porpellor
        propellor.Rotate(0, 0,propellorSpeed * Time.deltaTime);
    }
}
