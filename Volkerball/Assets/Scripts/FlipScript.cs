using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlipScript : MonoBehaviour
{
    WheelJoint2D wheelJoints;
    JointMotor2D jointMotor;

    void Start()
    {
        wheelJoints = gameObject.GetComponent<WheelJoint2D>();
        jointMotor = wheelJoints.motor;
        jointMotor.motorSpeed = 0;
        jointMotor.maxMotorTorque = 0;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 10000;
            jointMotor.maxMotorTorque = 100000;
        }
        else
        {
            jointMotor.motorSpeed = -1000;
        }
        wheelJoints.motor = jointMotor;
    }
    
}
