using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float forwardSpeed;
    public bool Camera_Movement=false;
     
    // Update is called once per frame
    void Update()
    {
        if (Variables.firsttouch == 1 && Camera_Movement==false)
        {           
            transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
        }
        
    }
}
