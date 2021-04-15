using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcontrol : MonoBehaviour
{
    WheelJoint2D wj;
    JointMotor2D mo;
    void Start()
    {
        wj = gameObject.GetComponents<WheelJoint2D>()[0];
        mo = new JointMotor2D();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mo.motorSpeed = -300;
            mo.maxMotorTorque = 1000;
            wj.useMotor = true;
            wj.motor = mo;
            
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            wj.useMotor = false;
        }
    }
}
