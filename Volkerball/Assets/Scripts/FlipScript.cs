using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlipScript : MonoBehaviour
{
    WheelJoint2D wheelJoints;
    JointMotor2D jointMotor;
    //public Transform start;
    //Vector2 begin;

    void Start()
    {
        wheelJoints = gameObject.GetComponent<WheelJoint2D>();
        //start = gameObject.transform;
       // begin = start.position;
        jointMotor = wheelJoints.motor;
        jointMotor.motorSpeed = 0;
        //jointMotor.maxMotorTorque = 0;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 100000;
            jointMotor.maxMotorTorque = 100000;
        }
        else
        {
           // gameObject.transform.position = begin;
            jointMotor.motorSpeed = -100000;
        }
        wheelJoints.motor = jointMotor;
    }
    
}
