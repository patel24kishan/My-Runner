using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float xInput,yInput;
    public float speed = 10f; 
    public float clampSideMovement = 10f;
    public float clampMinForwardMovement, clampMaxForwardMovement;

    [SerializeField] GameObject foodBullets;
    [SerializeField] Transform shootRef;


    // Update is called once per frame
    void Update()
    {
       

        //clampVlaue
        if (transform.position.x < -clampSideMovement)
        {
            transform.position=new Vector3(-clampSideMovement, transform.position.y,transform.position.z);
        }
        if (transform.position.x > clampSideMovement)
        {
            transform.position = new Vector3(clampSideMovement, transform.position.y, transform.position.z);
        }

        if (transform.position.z <clampMinForwardMovement)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, clampMinForwardMovement);
        }
        if (transform.position.z > clampMaxForwardMovement)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, clampMaxForwardMovement);
        }

        xInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * xInput * speed * Time.deltaTime);

        yInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * yInput * speed * Time.deltaTime);

        // Input Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodBullets,shootRef.position,Quaternion.identity);
        }

    }
}
