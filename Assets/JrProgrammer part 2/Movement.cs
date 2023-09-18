using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 2f;
    public float modifiedGravity = 4.5f;
    public bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        Physics.gravity *= modifiedGravity;
    }

    // Update is called once per frame
    void Update()
    {
        // Input Space
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isGrounded=false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       isGrounded=true;
    }
}
