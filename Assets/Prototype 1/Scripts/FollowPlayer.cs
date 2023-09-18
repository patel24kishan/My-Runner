using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform car;
    public Vector3 offset = new Vector3(-0.0124793649f, 5.6500001f, -12.9399996f); //default position
    public bool changeCamera = true;
    private void Start()
    {
    }

    void LateUpdate()
    {
        
        // follow using offset
        transform.position = car.transform.position +offset;
        
       
    }
    private void Update()
    {
        //Switch camera usung reference point
        if (Input.GetKey(KeyCode.X))
        {
            changeCamera = !changeCamera;
            switchCamera(changeCamera);
        }
    }

    private void switchCamera(bool flag) {
        if(flag)
        {
            offset = new Vector3(-0.0124793649f, 5.6500001f, -12.9399996f);
        }
        else
        {
            offset = new Vector3(Mathf.Abs(-0.949999988f), Mathf.Abs(2.3900001f), Mathf.Abs(-4.61999989f));
        }
    }
}
