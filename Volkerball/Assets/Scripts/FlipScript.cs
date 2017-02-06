﻿using System.Collections;
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
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 1000000;
        }
        else
        {
            jointMotor.motorSpeed = 0;
        }
        wheelJoints.motor = jointMotor;
    }
    
}
