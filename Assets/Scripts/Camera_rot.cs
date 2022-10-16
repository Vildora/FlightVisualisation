using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_rot : MonoBehaviour
{
    public float speed = 0;
    float xRot;
    float zRot;
   // float yRot;
    public float sensivity = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        if(speed == 0)
        {
            MouseMove();
        }
        if(sensivity == 0 && speed != 0)
        {
            AutoMove();


        }

        
       
    }
    void MouseMove()
    {
        if(Input.GetMouseButton(2))
        {
            xRot += Input.GetAxis("Mouse X") * sensivity;
            zRot += Input.GetAxis("Mouse Y") * sensivity;
            //yRot += Input.GetAxis("Mouse Y") * sensivity;
            transform.rotation = Quaternion.Euler (-zRot, xRot, 0f);
        }
    }
    void AutoMove()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);

    }
}
