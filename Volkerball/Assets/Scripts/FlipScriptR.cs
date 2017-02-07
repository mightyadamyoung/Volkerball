using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlipScriptR : MonoBehaviour
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

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = -10000;
            jointMotor.maxMotorTorque = 100000;
        }
        else
        {
            jointMotor.motorSpeed = 10000;
        }
        wheelJoints.motor = jointMotor;
    }
}
