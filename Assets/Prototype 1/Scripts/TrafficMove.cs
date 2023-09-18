using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    void FixedUpdate()
    {
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime*speed);
    }
}
